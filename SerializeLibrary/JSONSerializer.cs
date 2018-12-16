using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using TransportLibrary;

namespace SerializeLibrary
{
    public class JSONSerializer : ISerialize
    {
        public List<T> Load<T>(string path)
        {
            List<T> data = new List<T>();
            FileInfo file = new FileInfo(path);

            if (file.Exists)
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    DataContractJsonSerializer reader = new DataContractJsonSerializer(typeof(List<T>));
                    data = (List<T>)reader.ReadObject(fs);
                }
            }

            return data;
        }

        public void Save<T>(string path, List<T> data)
        {
            using (FileStream fs = new FileStream(path + ".json", FileMode.Create))
            {
                DataContractJsonSerializer writer = new DataContractJsonSerializer(typeof(List<T>));
                writer.WriteObject(fs, data);
            }
        }
    }
}
