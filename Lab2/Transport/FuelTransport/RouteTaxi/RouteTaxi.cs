using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public abstract class RouteTaxi : FuelPoweredTransport
    {
        public RouteTaxi(ID id, string owner_company, Route route, int max_fuel_amount, int fuel_consumption)
            : base(id, owner_company, max_fuel_amount, fuel_consumption)
        {
            Route = route;
        }

        public override string ToString()
        {
            return (Route != null) ?
                base.ToString() + " [" + Route.ToString() + "]" :
                base.ToString() + " [Add route!]";
        }
    }
}
