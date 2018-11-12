using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class CircleRouteTaxi : RouteTaxi
    {
        private int _currentwpindex_;

        public CircleRouteTaxi(ID id, string owner_company, Route route)
            : base(id, owner_company, route)
        {
            _currentwpindex_ = -1;
        }

        public override void Move()
        {
            if (Route != null)
            {
                if (_currentwpindex_ + 1 < Route.Waypoints.Count)
                {
                    Console.WriteLine(ToString() + " is at the point: " + Route.Waypoints[++_currentwpindex_].ToString());
                }
                if (_currentwpindex_ == Route.Waypoints.Count - 1)
                {
                    Console.WriteLine("End of the route reached. The car is in start location.");
                    _currentwpindex_ = 0;
                }
            }
        }
    }
}
