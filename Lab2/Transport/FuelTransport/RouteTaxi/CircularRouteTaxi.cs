using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public class CircularRouteTaxi : RouteTaxi
    {
        private int _currentwpindex_;

        public CircularRouteTaxi(ID id, string owner_company, Route route, int max_fuel_amount, int fuel_consumption)
            : base(id, owner_company, route, max_fuel_amount, fuel_consumption)
        {
            _currentwpindex_ = -1;
        }

        public CircularRouteTaxi(CircularRouteTaxi car)
            : base(car)
        {
        }

        public override void Move()
        {
            try
            {
                if (Route != null)
                {
                    base.Move();

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
                else
                {
                    MessageBox.Show("Doesn't have route!");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
