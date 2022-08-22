using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kilometer_to_meter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the distance in kilometers");
            double x=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The distance in meters is ");
            double y = x*1000;
            Console.WriteLine(y);

            Console.WriteLine("Enter the ditance in meters");
            double g=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("the distance in kilometers is");
            double h = g/1000;
            
            Console.WriteLine(h);

            Console.ReadLine();
        }
    }
}
