using System;
using System.Runtime.Serialization;

namespace TransportLibrary
{
    [Serializable]
    [DataContract]
    public class CarID : ID
    {
        private CarID()
            : base("")
        {
        }

        public CarID(int id)
            : base("C" + id.ToString())
        {
        }
    }
}
