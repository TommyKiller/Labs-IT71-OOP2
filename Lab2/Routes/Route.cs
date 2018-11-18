using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Route : IEquatable<Route>
    {
        public ID ID { get; }
        public List<Waypoint> Waypoints { get; }

        public Route(ID id)
        {
            ID = id;
            Waypoints = new List<Waypoint>();
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
    }
}
