using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ps_5Strupper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string lower = "i am a string";
            string upper;
            Console.WriteLine("\nString before converting to upper is " + lower);
            upper = lower.ToUpper();
            Console.WriteLine("\nString after converting to upper is "  +  upper);
            
            Console.ReadLine();
        }
    }
}
