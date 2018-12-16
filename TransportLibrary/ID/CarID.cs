using System;

namespace TransportLibrary
{
    [Serializable]
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
