using System;

namespace TransportLibrary
{
    [Serializable]
    public class CarID : ID
    {
        public CarID(int id)
            : base("C" + id.ToString())
        {
        }
    }
}
