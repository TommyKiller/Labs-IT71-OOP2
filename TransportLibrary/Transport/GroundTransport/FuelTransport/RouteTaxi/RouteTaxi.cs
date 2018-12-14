using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace TransportLibrary
{
    public class RouteTaxi : FuelTransport, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        private RouteID routeID;
        public RouteID RouteID
        {
            get
            {
                return routeID;
            }
            set
            {
                routeID = value;
                PropertyChanged(this, new PropertyChangedEventArgs("RouteID"));
            }
        }

        public RouteTaxi(CarID id, string owner_company, RouteID routeID, int max_fuel_amount, int fuel_consumption)
            : base(id, owner_company, max_fuel_amount, fuel_consumption)
        {
            RouteID = routeID;
        }

        public RouteTaxi(RouteTaxi taxi)
            : base(taxi.ID, String.Copy(taxi.Company), taxi.FuelCapacity, taxi.FuelConsumption)
        {
            RouteID = taxi.RouteID;
        }

        public override string ToString()
        {
            return (RouteID != null) ?
                base.ToString() + " [" + RouteID.ToString() + "]" :
                base.ToString() + " [Add route!]";
        }
    }
}
