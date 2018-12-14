using System.Collections.Generic;

namespace SerializeLibrary
{
    public interface ISerialize
    {
        void Save<T>(string path, List<T> dataList);

        List<T> Load<T>(string path);
    }
}
