using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meter_to_kilometer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double USdollar = 0;
            double inr = 0;
            double value = 0;

            Console.Write("Enter amount in USdollar: ");
            USdollar = double.Parse(Console.ReadLine());

            Console.Write("Enter USdollar value: ");
            value = double.Parse(Console.ReadLine());

            inr = USdollar * value;
            Console.WriteLine("USdollar"         +  USdollar  +          "is inr"        +     inr);
            Console.ReadLine();


        }
    }
}
