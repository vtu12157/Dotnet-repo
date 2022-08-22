using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace one_is_posit_and_one_is_neg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nEnter the first integer:");
            int x = Convert.ToInt32(Console.ReadLine());


          
            Console.WriteLine("\nEnter the second integer:");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("check if one is positive and one is negative");
            Console.WriteLine((x < 0 && y > 0) || (x > 0 && y < 0));
            Console.ReadLine();
        }
    }
}
