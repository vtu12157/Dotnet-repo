using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ps_1_Strcmp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1, s2;
            s1 = "Hello";
            s2 = "Hello";
            if (s1.Equals(s2))
            {
                Console.WriteLine("Both the strings are equal");

            }
            else {
                Console.WriteLine("Strings are not equal");
               
            }
            Console.ReadLine();
        }
    }
}
