using System;

namespace TransportLibrary
{
    [Serializable]
    public class RouteID : ID
    {
        private RouteID()
            : base("")
        {

        }

        public RouteID(int id)
            : base("R" + id.ToString())
        {
        }
    }
}
