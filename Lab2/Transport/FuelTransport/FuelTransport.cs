using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    abstract class FuelTransport : CityTransport
    {
        private int _max_fuel_amount;
        private int _fuel_amount;
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
                else if (value > _max_fuel_amount)
                {
                    throw new Exception("The tank is full!");
                }
                else
                {
                    _fuel_amount = value;
                }
            }
        }

        public FuelTransport(ID id, string owner_company)
            : base(id, owner_company)
        {

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
