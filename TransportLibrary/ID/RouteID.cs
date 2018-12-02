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

        public override object Clone()
        {
            RouteID routeID = this.MemberwiseClone() as RouteID;
            routeID._id = String.Copy(this._id);
            return routeID;
        }
    }
}
