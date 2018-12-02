using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportLibrary
{
    public abstract class GroundTransport : Transport
    {
        public GroundTransport(CarID id, string owner_company) : base(id, owner_company)
        {
        }

        public override void Move()
        {
            // Move on the ground implementation //
        }
    }
}
