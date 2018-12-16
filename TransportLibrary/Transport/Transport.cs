using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace TransportLibrary
{
    [Serializable]
    [KnownType(typeof(RouteTaxi))]
    [DataContract]
    public abstract class Transport
    {
        [DataMember]
        public CarID ID { get; protected set; }
        [DataMember]
        public string Company { get; set; }
        [IgnoreDataMember]
        [XmlIgnore]
        public static Dictionary<CarID, Transport> Cars { get; set; }

        protected Transport() { }

        public Transport(CarID id, string owner_company)
        {
            ID = id;
            Company = owner_company;
        }

        public override string ToString()
        {
            return "Car " + ID.ToString();
        }
    }
}
