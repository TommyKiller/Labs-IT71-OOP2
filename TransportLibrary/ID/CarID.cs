using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportLibrary
{
    public class CarID : ID
    {
        public CarID(int id)
            : base("C" + id.ToString())
        {
        }

        public override object Clone()
        {
            CarID carID = this.MemberwiseClone() as CarID;
            carID._id = String.Copy(this._id);
            return carID;
        }
    }
}
