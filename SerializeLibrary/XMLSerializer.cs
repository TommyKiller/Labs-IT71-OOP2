using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace SerializeLibrary
{
    public class XMLSerializer : ISerialize
    {
        public Dictionary<TKey, TValue> Load<TKey, TValue>(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(XmlSerializableDictionary<TKey, TValue>));
            XmlSerializableDictionary<TKey, TValue> tempDict;

            using (StreamReader streamWriter = new StreamReader(path))
            {
                tempDict = serializer.Deserialize(streamWriter) as XmlSerializableDictionary<TKey, TValue>;
            }

            Dictionary<TKey, TValue> data = new Dictionary<TKey, TValue>();
            foreach (KeyValuePair<TKey, TValue> pair in tempDict)
            {
                data.Add(pair.Key, pair.Value);
            }

            return data;
        }

        public void Save<TKey, TValue>(string path, Dictionary<TKey, TValue> data)
        {
            XmlSerializableDictionary<TKey, TValue> tempDict = new XmlSerializableDictionary<TKey, TValue>();
            foreach(KeyValuePair<TKey, TValue> pair in data)
            {
                tempDict.Add(pair.Key, pair.Value);
            }

            XmlSerializer serializer = new XmlSerializer(typeof(XmlSerializableDictionary<TKey, TValue>));
            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                serializer.Serialize(streamWriter, tempDict);
            }
        }
    }
}
