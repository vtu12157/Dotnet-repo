using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ps_12_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numarr = { 10, 54, 87, 69, 78, 89 };

            Console.WriteLine("Minimal num is:"+ numarr.Min());
            Console.WriteLine("Maximum num is:" + numarr.Max());//
            Console.ReadLine();
        }
    }
}
