using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using SerializeLibrary;

namespace TransportLibrary
{
    [Serializable]
    public class Route : IEquatable<Route>, IXmlSerializable
    {
        public RouteID ID { get; private set; }
        public List<Waypoint> Waypoints { get; private set; }
        public RouteTypes RouteType { get; private set; }
        public static Dictionary<RouteID, Route> Routes { get; set; }

        public static List<RouteID> GetRoutesOfType(RouteTypes routeType)
        {
            List<RouteID> routesIDList = new List<RouteID>();

            foreach (RouteID id in Routes.Keys)
            {
                if (Routes[id].RouteType == routeType)
                {
                    routesIDList.Add(id);
                }
            }

            return routesIDList;
        }

        private Route()
        {

        }

        public Route(RouteID id)
        {
            ID = id;
            Waypoints = new List<Waypoint>();
        }

        public Route(Route route)
        {
            ID = route.ID;
            RouteType = route.RouteType;

            Waypoints = new List<Waypoint>();
            foreach (Waypoint wp in route.Waypoints)
            {
                Waypoints.Add(new Waypoint(wp));
            }
        }

        public void RemoveWaypoint(Waypoint wp)
        {
            Waypoints.Remove(wp);

            RouteType = Waypoints.First() == Waypoints.Last() ? RouteTypes.Circular : RouteTypes.Direct;
        }

        public void AddWaypoint(Waypoint wp)
        {
            Waypoints.Add(wp);

            RouteType = Waypoints.First() == Waypoints.Last() ? RouteTypes.Circular : RouteTypes.Direct;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Route);
        }

        public bool Equals(Route other)
        {
            return (!ReferenceEquals(other, null)) && (ReferenceEquals(other, this) || ID == other.ID);
        }

        public static bool operator ==(Route left, Route right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Route left, Route right)
        {
            return !Equals(left, right);
        }

        public override string ToString()
        {
            return "Route " + ID;
        }

        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            ID = new RouteID(0);
            ID.ReadXml(reader);
            RouteType = (RouteTypes)Int32.Parse(reader["RouteType"]);

            if (reader.ReadToDescendant("WaypointsList"))
            {
                while (reader.MoveToContent() == XmlNodeType.Element && reader.LocalName == "WaypointsList")
                {
                    Waypoint wp = new Waypoint("");
                    wp.ReadXml(reader);
                    Waypoints.Add(wp);
                }
            }
            reader.Read();
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteAttributeString("RouteType", RouteType.ToString());
            writer.WriteAttributeString("RouteID", ID.ToString());

            foreach(Waypoint wp in Waypoints)
            {
                writer.WriteStartElement("WaypointsList");
                wp.WriteXml(writer);
                writer.WriteEndElement();
            }
        }
    }
}
