using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class ID : IEquatable<ID>
    {
        public int _id { get; }

        public ID(int id)
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
            return (_id != 0) ? _id.GetHashCode() : 0;
        }
    }
}
