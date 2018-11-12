using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    abstract class CityTransport
    {
        public Route Route { get; set; }
        public ID ID { get; }
        public string Company { get; }

        public CityTransport(ID id, string owner_company)
        {
            ID = id;
            Company = owner_company;
        }

        public abstract void FillUp(int value);

        public abstract void Move();

        public override string ToString()
        {
            return "Car " + ID.ToString();
        }
    }
}
