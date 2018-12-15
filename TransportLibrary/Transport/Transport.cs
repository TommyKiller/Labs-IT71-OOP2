using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace TransportLibrary
{
    [Serializable]
    public abstract class Transport : IXmlSerializable
    {
        public CarID ID { get; protected set; }
        public string Company { get; set; }
        public static Dictionary<CarID, Transport> Cars { get; set; }

        public Transport(CarID id, string owner_company)
        {
            ID = id;
            Company = owner_company;
        }

        public override string ToString()
        {
            return "Car " + ID.ToString();
        }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public virtual void ReadXml(XmlReader reader)
        {
            throw new NotImplementedException();
        }

        public virtual void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }
    }
}
