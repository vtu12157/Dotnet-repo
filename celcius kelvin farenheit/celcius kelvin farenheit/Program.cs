using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace celcius_kelvin_farenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int celcius;
            Console.Write("enter the temp in celcius:");
            celcius=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("temp in kelvin={0}", celcius + 273);
            Console.WriteLine("temp in Fahrenheit={0}", celcius * 18 / 10 + 32);
            Console.ReadLine();
        }


    }
}
