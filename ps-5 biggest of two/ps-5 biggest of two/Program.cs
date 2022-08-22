using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ps_5_biggest_of_two
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter the first number:");
            a=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Second number:");
            b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
                Console.WriteLine("Biggest number is " + a);
            else
                Console.WriteLine("Biggest number is" + b);

            Console.ReadLine();

        }
    }
}
