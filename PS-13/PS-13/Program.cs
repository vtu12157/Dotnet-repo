using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, rem1;
            Console.WriteLine("Input the integer");
            num1=Convert.ToInt32(Console.ReadLine());

            rem1 = num1 % 2;

            if (rem1 == 0)
            {
                Console.WriteLine("{0} is an even number", num1);
            }
            else if(rem1!=0)
            {
                Console.WriteLine("{0} is an odd number", num1);
            }
            else if(num1 == 0)
                    {
                Console.WriteLine("{0} is equal to zero", num1);
                    }
            else if(num1>100)
                Console.WriteLine("{0} is a larger number", num1);

            Console.ReadLine();


        }
    }
}
