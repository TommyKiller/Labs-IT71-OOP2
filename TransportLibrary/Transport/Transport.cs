using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportLibrary
{
    public abstract class Transport : ICloneable
    {
        public CarID ID { get; protected set; }
        public string Company { get; set; }

        public Transport(CarID id, string owner_company)
        {
            ID = id;
            Company = owner_company;
        }

        public abstract void Move();

        public abstract object Clone();

        public override string ToString()
        {
            return "Car " + ID.ToString();
        }
    }
}
