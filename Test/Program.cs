using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dict1 = new Dictionary<int, string>
            {
                { 0, "first" },
                { 1, "second" },
                { 2, "third" }
            };
            Dictionary<int, string> dict2 = new Dictionary<int, string>
            {
                { 1, "second" }
            };
            IEnumerable<KeyValuePair<int, string>> except = dict1.Except(dict2);
            Dictionary<int, string> dict3 = new Dictionary<int, string>();
            dict2.Clear();
            foreach (KeyValuePair<int, string> item in except)
            {
                dict3.Add(item.Key, item.Value);
            }
            foreach (int id in dict3.Keys)
            {
                Console.WriteLine(dict3[id]);
            }
            Console.ReadLine();
        }
    }
}
