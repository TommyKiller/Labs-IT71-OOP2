using System;

namespace TransportLibrary
{
    [Serializable]
    public abstract class GroundTransport : Transport
    {
        public GroundTransport(CarID id, string owner_company) : base(id, owner_company)
        {
        }
    }
}
