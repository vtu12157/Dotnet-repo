using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ps_11_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, string> dictionary = new SortedDictionary<int, string>();

            dictionary.Add(10,"Ram");

            dictionary.Add(4, "Cat");
            foreach ( var kvp in dictionary)
            {
                Console.WriteLine(kvp.Value);
            }

            Console.ReadLine();
        }
    }
}
