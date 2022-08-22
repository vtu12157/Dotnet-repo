using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ps_4_check_both_stirgs_are_equal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1, s2;
            Console.WriteLine("Enter the first string:");
            s1=Console.ReadLine();

            Console.WriteLine("Enter the second string");
            s2=Console.ReadLine();

            if (s1 == s2)
                Console.WriteLine("Both the strings are equal");
            else
                Console.WriteLine("Strings are not equal");

            Console.ReadLine();
                
        }
    }
}
