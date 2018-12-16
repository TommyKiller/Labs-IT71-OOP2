using System;
using System.Runtime.Serialization;

namespace TransportLibrary
{
    [Serializable]
    [DataContract]
    public class Waypoint : IEquatable<Waypoint>
    {
        [DataMember]
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
    }
}
