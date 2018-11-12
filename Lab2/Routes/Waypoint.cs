using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Waypoint : IEquatable<Waypoint>
    {
        public string Adress { get; set; }

        public Waypoint(string adress)
        {
            Adress = adress;
        }

        public override string ToString()
        {
            return Adress;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Waypoint objAsWaypoint = obj as Waypoint;
            if (objAsWaypoint == null) return false;
            else return Equals(objAsWaypoint);
        }

        public bool Equals(Waypoint other)
        {
            if (other == null) return false;
            return (Adress == other.Adress) ? true : false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
