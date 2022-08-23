using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ps_8_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable numberNames = new Hashtable();
            numberNames.Add(1, "One");
            numberNames.Add(2, "Two");
            numberNames.Add(3, "Three");

            Console.WriteLine("Before removing the element");
            foreach (DictionaryEntry kvp in numberNames)
            Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            

            numberNames.Remove(1);
            Console.WriteLine("\nAfter removing the element");
            foreach (DictionaryEntry kvp in numberNames)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            Console.ReadLine();

        }


    }
}
