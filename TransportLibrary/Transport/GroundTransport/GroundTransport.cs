using System;
using System.Runtime.Serialization;

namespace TransportLibrary
{
    [Serializable]
    [DataContract]
    public abstract class GroundTransport : Transport
    {
        protected GroundTransport() { }

        public GroundTransport(CarID id, string owner_company) : base(id, owner_company)
        {
        }
    }
}
