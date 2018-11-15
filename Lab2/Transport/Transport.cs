using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    abstract class Transport
    {
        public Route Route { get; set; }
        public ID ID { get; }
        public string Company { get; set; }

        public Transport(ID id, string owner_company)
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
