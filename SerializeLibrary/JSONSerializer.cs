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

        public void Save<T>(string path, List<T> dataList)
        {
            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                using (JsonWriter writer = new JsonTextWriter(streamWriter))
                {
                    serializer.Serialize(writer, dataList);
                }
            }
        }

        public List<T> Load<T>(string path)
        {
            List<T> data;

            using (StreamReader streamWriter = new StreamReader(path))
            {
                using (JsonReader writer = new JsonTextReader(streamWriter))
                {
                    data = serializer.Deserialize(writer) as List<T>;
                }
            }

            return data;
        }
    }
}
