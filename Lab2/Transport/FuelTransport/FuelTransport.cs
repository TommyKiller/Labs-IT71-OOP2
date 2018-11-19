using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public abstract class FuelTransport : Transport
    {
        private int _fuel_amount;
        public int FuelCapacity { get; set; }
        public int FuelConsumption { get; set; }
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

        public FuelTransport(ID id, string owner_company, int max_fuel_amount, int fuel_consumption)
            : base(id, owner_company)
        {
            FuelCapacity = max_fuel_amount;
            FuelConsumption = fuel_consumption;
            Fuel = max_fuel_amount;
        }

        public FuelTransport(FuelTransport car)
            : base(car)
        {
            FuelCapacity = car.FuelCapacity;
            FuelConsumption = car.FuelConsumption;
            Fuel = car.Fuel;
        }

        public override void Move()
        {
            Fuel -= FuelConsumption;
        }

        public override void FillUp(int value)
        {
            try
            {
                Fuel += value;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
