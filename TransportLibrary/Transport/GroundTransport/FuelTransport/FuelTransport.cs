using System;
using System.Runtime.Serialization;

namespace TransportLibrary
{
    [Serializable]
    [DataContract]
    public abstract class FuelTransport : GroundTransport
    {
        [DataMember]
        public int FuelCapacity { get; private set; }
        [DataMember]
        public int FuelConsumption { get; private set; }
        [DataMember]
        public int Fuel { get; protected set; }

        protected FuelTransport() { }

        public FuelTransport(CarID id, string owner_company, int max_fuel_amount, int fuel_consumption)
            : base(id, owner_company)
        {
            FuelCapacity = max_fuel_amount;
            FuelConsumption = fuel_consumption;
            Fuel = max_fuel_amount;
        }
    }
}
