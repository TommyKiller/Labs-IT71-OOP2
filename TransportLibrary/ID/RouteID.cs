using System;
using System.Runtime.Serialization;

namespace TransportLibrary
{
    [Serializable]
    [DataContract]
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
