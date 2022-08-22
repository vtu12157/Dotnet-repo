using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ps1_to_find_min_and_max_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int min;
            int max;
            Console.Write("Enter the first number:");
            a=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Second number:");
            b=Convert.ToInt32(Console.ReadLine());

            if (a > b)
                max = a;
            else
                max = b;

            if (a < b)
                min = a;
            else
                min = b;

            Console.WriteLine("Minimum number is={0}", min);
            Console.WriteLine("Maximum number is ={0}", max);

            Console.ReadLine();




        }
    }
}
