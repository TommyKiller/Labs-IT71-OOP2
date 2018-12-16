using System;

namespace TransportLibrary
{
    [Serializable]
    public abstract class GroundTransport : Transport
    {
        protected GroundTransport()
        {

        }

        public GroundTransport(CarID id, string owner_company) : base(id, owner_company)
        {
        }
    }
}
