using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerializeLibrary
{
    public class BinarySerializer : ISerialize
    {
        private readonly BinaryFormatter serializer;

        public BinarySerializer()
        {
            serializer = new BinaryFormatter();
        }

        public Dictionary<TKey, TValue> Load<TKey, TValue>(string path)
        {
            Dictionary<TKey, TValue> data;

            using (FileStream stream = new FileStream(path, FileMode.Open))
            {
                data = (Dictionary<TKey, TValue>)serializer.Deserialize(stream);
            }

            return data;
        }

        public void Save<TKey, TValue>(string path, Dictionary<TKey, TValue> data)
        {
            using (FileStream stream = new FileStream(path, FileMode.OpenOrCreate))
            {
                serializer.Serialize(stream, data);
            }
        }
    }
}
