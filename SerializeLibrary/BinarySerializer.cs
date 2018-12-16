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

        public List<T> Load<T>(string path)
        {
            List<T> data = new List<T>();
            FileInfo file = new FileInfo(path);

            if (file.Exists)
            {
                using (FileStream stream = new FileStream(path, FileMode.Open))
                {
                    data = (List<T>)serializer.Deserialize(stream);
                }
            }

            return data;
        }

        public void Save<T>(string path, List<T> data)
        {
            using (FileStream stream = new FileStream(path + ".bin", FileMode.Create))
            {
                serializer.Serialize(stream, data);
            }
        }
    }
}
