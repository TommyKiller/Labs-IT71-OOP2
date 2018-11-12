using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Route : IEquatable<Route>
    {
        public ID ID { get; }
        public List<Waypoint> Waypoints { get; }

        public Route(ID id)
        {
            this.ID = id;
            Waypoints = new List<Waypoint>();
        }

        public bool Equals(Route other)
        {
            if (other == null) return false;
            return ID.Equals(other.ID);
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Route objAsRoute = obj as Route;
            if (objAsRoute == null) return false;
            else return Equals(objAsRoute);
        }

        public override string ToString()
        {
            return "Route " + ID;
        }

        public override int GetHashCode()
        {
            return ID._id_;
        }
    }
}
