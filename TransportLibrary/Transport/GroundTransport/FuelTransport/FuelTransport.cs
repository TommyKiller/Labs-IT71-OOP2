using System;
using System.Xml;

namespace TransportLibrary
{
    [Serializable]
    public abstract class FuelTransport : GroundTransport
    {
        private int _fuel_amount;

        public int FuelCapacity { get; private set; }
        public int FuelConsumption { get; private set; }
        public int Fuel
        {
            get
            {
                return _fuel_amount;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new Exception("Not enough fuel!");
                }
                else if (value > FuelCapacity)
                {
                    throw new Exception("The tank is full!");
                }
                else
                {
                    _fuel_amount = value;
                }
            }
        }

        public FuelTransport(CarID id, string owner_company, int max_fuel_amount, int fuel_consumption)
            : base(id, owner_company)
        {
            FuelCapacity = max_fuel_amount;
            FuelConsumption = fuel_consumption;
            Fuel = max_fuel_amount;
        }

        public override void ReadXml(XmlReader reader)
        {
            base.ReadXml(reader);
        }

        public override void WriteXml(XmlWriter writer)
        {
            base.WriteXml(writer);
        }
    }
}
