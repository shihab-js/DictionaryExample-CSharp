using System;
using System.Collections.Generic;

namespace DictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //create dictionary..
            Dictionary<int, string> names = new Dictionary<int, string>();

            //add elements
            names.Add(1, "Shihab");
            names.Add(2, "Mishu");
            names.Add(3, "Mithila");
            names.Add(4, "Rayhan");

            //Iterate the the dictionary
            foreach(KeyValuePair<int,string> kv in names)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }

        }
    }
}
