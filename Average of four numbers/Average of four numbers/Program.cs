using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_of_four_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4;

            Console.WriteLine("enter the first number for avg:");
            num1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the second number for avg:");
            num2 =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the third number for avg:");
            num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the fourth number for avg:");
            num4 = Convert.ToInt32(Console.ReadLine());



            int result = (num1 + num2 + num3 + num4) / 4;

            Console.WriteLine("the avg of all numbers is");
            Console.WriteLine(result);


            Console.ReadLine();

        }
    }
}
