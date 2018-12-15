using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace SerializeLibrary
{
    public class JSONSerializer : ISerialize
    {
        private readonly JsonSerializer serializer;

        public JSONSerializer()
        {
            serializer = new JsonSerializer();
        }

        public Dictionary<TKey, TValue> Load<TKey, TValue>(string path)
        {
            Dictionary<TKey, TValue> data;

            using (StreamReader streamWriter = new StreamReader(path))
            {
                using (JsonReader writer = new JsonTextReader(streamWriter))
                {
                    data = serializer.Deserialize(writer) as Dictionary<TKey, TValue>;
                }
            }

            return data;
        }

        public void Save<TKey, TValue>(string path, Dictionary<TKey, TValue> data)
        {
            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                using (JsonWriter writer = new JsonTextWriter(streamWriter))
                {
                    serializer.Serialize(writer, data);
                }
            }
        }
    }
}
