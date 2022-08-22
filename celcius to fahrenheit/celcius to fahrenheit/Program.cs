using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace celcius_to_fahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter temperature in celcius");
            int x=Convert.ToInt32(Console.ReadLine());

            int y=( (x*9)/5+32);
            Console.Write("The temperature in fahrenheit is:");
            Console.Write(y);
            Console.ReadLine();
        }
    }
}
