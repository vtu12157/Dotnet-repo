using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ps_2_Structures
{
    internal class Program
    {

        public static int Addition(  int a, int b)
        {
            return a + b;
        }


        static void Main(string[] args)
        {
            
            
                int a, b, c;


                Console.Write("Enter first number:");
                a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Second number:");
                b = Convert.ToInt32(Console.ReadLine());

               c= Addition(a,b);
                Console.WriteLine("Addition of the numbers is:" + c);
                Console.ReadLine();
            }
    }
}
