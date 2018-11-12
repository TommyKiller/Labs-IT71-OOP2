using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    abstract class RouteTaxi : FuelTransport
    {
        public RouteTaxi(ID id, string owner_company, Route route)
            : base(id, owner_company)
        {
            Route = route;
        }

        public override string ToString()
        {
            return base.ToString() + " [" + Route.ToString() + "]";
        }
    }
}
