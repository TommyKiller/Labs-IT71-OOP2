using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace TransportLibrary
{
    [Serializable]
    [DataContract]
    public class RouteTaxi : FuelTransport, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        [DataMember]
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
                PropertyChanged = delegate { };
                PropertyChanged(this, new PropertyChangedEventArgs("RouteID"));
            }
        }

        public static List<CarID> GetCarsOnRoute(RouteID routeID)
        {
            List<CarID> carsIDList = new List<CarID>();

            foreach (CarID id in Cars.Keys)
            {
                if ((Cars[id] as RouteTaxi != null) && (((RouteTaxi)Cars[id]).RouteID == routeID))
                {
                    carsIDList.Add(id);
                }
            }

            return carsIDList;
        }

        private RouteTaxi() { }

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
