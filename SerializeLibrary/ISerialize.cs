using System.Collections.Generic;

namespace SerializeLibrary
{
    public interface ISerialize
    {
        void Save<TKey, TValue>(string path, Dictionary<TKey, TValue> data);

        Dictionary<TKey, TValue> Load<TKey, TValue>(string path);
    }
}
