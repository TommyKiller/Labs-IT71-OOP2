using System;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace TransportLibrary
{
    [Serializable]
    public abstract class ID : IEquatable<ID>, IXmlSerializable
    {
        public string _id { get; private set; }

        public ID(string id)
        {
            _id = id;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as ID);
        }

        public bool Equals(ID other)
        {
            return (!ReferenceEquals(other, null)) && (ReferenceEquals(other, this) || _id == other._id);
        }

        public static bool operator ==(ID left, ID right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ID left, ID right)
        {
            return !Equals(left, right);
        }

        public override string ToString()
        {
            return _id.ToString();
        }

        public override int GetHashCode()
        {
            return (_id != string.Empty) ? _id.GetHashCode() : 0;
        }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            throw new NotImplementedException();
        }

        public void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }
    }
}
