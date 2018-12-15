using System;

namespace TransportLibrary
{
    [Serializable]
    public class RouteID : ID
    {
        public RouteID(int id)
            : base("R" + id.ToString())
        {
        }
    }
}
