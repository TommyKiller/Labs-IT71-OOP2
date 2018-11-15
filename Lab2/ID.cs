using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class ID : IEquatable<ID>
    {
        public int _id_ { get; }

        public ID(int id)
        {
            _id_ = id;
        }

        public bool Equals(ID other)
        {
            if (other == null) return false;
            return _id_.Equals(other._id_);
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            ID objAsID = obj as ID;
            if (objAsID == null) return false;
            else return Equals(objAsID);
        }

        public override string ToString()
        {
            return _id_.ToString();
        }

        public override int GetHashCode()
        {
            return _id_;
        }
    }
}
