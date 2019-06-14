using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating a dictionary object 
            // which takes integer as key and string as value
            Dictionary<int, string> dictionaryobj = new Dictionary<int, string>();
            // Adding elements to the dictionary
            dictionaryobj.Add(1, "Windows");
            dictionaryobj.Add(3, "Lunix");
            dictionaryobj.Add(0, "DOS");
            dictionaryobj.Add(2, "Unix");

            // printing the dictionary elements using KeyValuePair<TKey, TValue> struct
            foreach (KeyValuePair<int, string> pair in dictionaryobj)
            {
                Console.WriteLine("{0} {1}", pair.Key, pair.Value);
            }

            // Use var keyword to enumerate dictionary.
            foreach (var pair in dictionaryobj)
            {
                Console.WriteLine("{0} {1}", pair.Key, pair.Value);
            }

            // See whether Dictionary contains this key.
            if (dictionaryobj.ContainsKey(0))
            {
                string value = dictionaryobj[0];
                Console.WriteLine(value);
            }

            // Use TryGetValue.
            string test;
            if (dictionaryobj.TryGetValue(0, out test)) // Returns true.
            {
                Console.WriteLine(test); // This is the value at 0.
            }
            if (dictionaryobj.TryGetValue(5, out test)) // Returns false.
            {
                Console.WriteLine(test); // Not reached.
            }


        }
    }
}
