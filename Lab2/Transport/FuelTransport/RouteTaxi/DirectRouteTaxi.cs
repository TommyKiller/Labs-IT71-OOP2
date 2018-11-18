using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public class DirectRouteTaxi : RouteTaxi
    {
        private int _currentwpindex;
        private int _direction;

        public DirectRouteTaxi(ID id, string owner_company, Route route, int max_fuel_amount, int fuel_consumption)
               : base(id, owner_company, route, max_fuel_amount, fuel_consumption)
        {
            _currentwpindex = -1;
            _direction = 1;
        }

        public override void Move()
        {
            try
            {
                if (Route != null)
                {
                    base.Move();

                    if ((_currentwpindex - 1 >= 0) && (_currentwpindex + 1 < Route.Waypoints.Count))
                    {
                        _currentwpindex += _direction;
                        Console.WriteLine(ToString() + " is at the point: " + Route.Waypoints[_currentwpindex].ToString());
                    }
                    if ((_currentwpindex == 0) && (_currentwpindex == Route.Waypoints.Count - 1))
                    {
                        _direction *= -1;
                        Console.WriteLine("End of the route reached. The car turned around.");
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
