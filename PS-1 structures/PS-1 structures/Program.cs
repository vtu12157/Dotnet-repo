using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PS_1_structures
{
    internal class Program
    {
      public static void Addition(out int result,int a,int b)
        {
            result = a + b;
        }
        static void Main(string[] args)
        {
            int a, b,c;

            
            Console.Write("Enter first number:");
            a=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Second number:");
            b=Convert.ToInt32(Console.ReadLine());

             Addition(out c,a,b);
            Console.WriteLine("Addition of the numbers is:" + c);
            Console.ReadLine();

        }
    }
}
