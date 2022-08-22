using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ps_8_print_pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            for(x=1;x<=5;x++)
            {
                for (y=1;y<=x;y++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
            Console.ReadLine();
        }
    }
}
