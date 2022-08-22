using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Both_are_positive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nEnter the fist integer");
            int x=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter the second integer");
            int y=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("check if both are positive:");
            Console.WriteLine((x > 0 && y > 0));
            Console.ReadLine();

        }
    }
}
