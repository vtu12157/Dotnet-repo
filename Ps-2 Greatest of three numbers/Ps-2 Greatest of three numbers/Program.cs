using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ps_2_Greatest_of_three_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("Enter the three numbers: \n");

            num1=Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                    Console.WriteLine("The largest number is:"+num1);
                else
                    Console.WriteLine("The largest number is:"+num3);


            }

            else if (num2 > num3)
                Console.WriteLine("The largest number is"+num2);
            else
                Console.WriteLine("The largest number is"+num3);

            Console.ReadLine();

        }
        
    }
}
