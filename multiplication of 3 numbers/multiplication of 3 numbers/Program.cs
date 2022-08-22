using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplication_of_3_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.Write("Enter the first number for multiplication:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number for multiplication:");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the third number for multiplication:");
            num3 = Convert.ToInt32(Console.ReadLine());

            int result = num1 * num2 * num3;
            Console.WriteLine(result) ;
            Console.ReadLine();
        }
    }
}
