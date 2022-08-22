using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ps_3_compare_charecter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char a1, a2;

            Console.WriteLine("Enter the first charecter:");
            a1 = Console.ReadLine()[0];

            Console.WriteLine("Enter the second charecter:");
            a2= Console.ReadLine()[0];

            if (a1 == a2)
                Console.WriteLine("Both charecters are equal");
            else
                Console.WriteLine("charecters are not equal");

            Console.ReadLine();


        }
    }
}
