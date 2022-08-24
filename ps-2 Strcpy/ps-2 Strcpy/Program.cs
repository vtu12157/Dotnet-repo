using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ps_2_Strcpy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string d1;
            string d2;

            Console.Write("Enter the string :");
            d1 = Console.ReadLine();
            d2 = string.Copy(d1);

            Console.WriteLine("Value of firsrt string is:" + d1);
            Console.WriteLine("Value of Second string is:" + d2);
            Console.ReadLine();
        }
        
    }
}
