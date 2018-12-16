using System;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace TransportLibrary
{
    [Serializable]
    public class Waypoint : IEquatable<Waypoint>, IXmlSerializable
    {
        public string Adress { get; set; }

        public Waypoint(string adress)
        {
            Adress = adress;
        }

        public Waypoint(Waypoint waypoint)
        {
            Adress = String.Copy(waypoint.Adress);
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Waypoint);
        }

        public bool Equals(Waypoint other)
        {
            return (!ReferenceEquals(other, null)) && (ReferenceEquals(other, this) || Adress == other.Adress);
        }

        public static bool operator ==(Waypoint left, Waypoint right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Waypoint left, Waypoint right)
        {
            return !Equals(left, right);
        }

        public override int GetHashCode()
        {
            return (Adress == string.Empty) ? Adress.GetHashCode() : 0;
        }

        public override string ToString()
        {
            return Adress;
        }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            Adress = reader["Adress"];
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteAttributeString("Adress", Adress);
        }
    }
}
