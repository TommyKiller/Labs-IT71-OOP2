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
    }
}
