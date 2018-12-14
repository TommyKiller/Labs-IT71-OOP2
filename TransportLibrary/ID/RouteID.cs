using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportLibrary
{
    public class RouteID : ID
    {
        public RouteID(int id)
            : base("R" + id.ToString())
        {
        }
    }
}
