using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;

namespace SerializeLibrary
{
    public class XMLSerializer : ISerialize
    {
        public List<T> Load<T>(string path)
        {
            List<T> data = new List<T>();
            FileInfo file = new FileInfo(path);

            if (file.Exists)
            {
                using (FileStream stream = new FileStream(path, FileMode.Open))
                {
                    using (XmlDictionaryReader reader = XmlDictionaryReader.CreateTextReader(stream, new XmlDictionaryReaderQuotas()))
                    {
                        DataContractSerializer serializer = new DataContractSerializer(typeof(List<T>));
                        data = (List<T>)serializer.ReadObject(reader);
                    }
                }
            }

            return data;
        }

        public void Save<T>(string path, List<T> data)
        {
            using (FileStream stream = new FileStream(path + ".xml", FileMode.Create))
            {
                using (XmlDictionaryWriter writer = XmlDictionaryWriter.CreateTextWriter(stream))
                {
                    DataContractSerializer serializator = new DataContractSerializer(typeof(List<T>));
                    serializator.WriteObject(writer, data);
                }
            }
        }
    }
}
