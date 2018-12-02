using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportLibrary
{
    public class Waypoint : IEquatable<Waypoint>, ICloneable
    {
        public string Adress { get; set; }

        public Waypoint(string adress)
        {
            Adress = adress;
        }

        public object Clone()
        {
            Waypoint wp = this.MemberwiseClone() as Waypoint;
            wp.Adress = String.Copy(this.Adress);
            return wp;
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
