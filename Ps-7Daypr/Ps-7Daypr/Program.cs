using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ps_7Daypr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime b = new DateTime();
            b=DateTime.Now;
            Console.WriteLine("Year:" + b.Year);
            Console.WriteLine("Month:" + b.Month);
            Console.WriteLine("Day:" + b.Day);
            Console.WriteLine("hour:" + b.Hour);
            Console.WriteLine("Minute:" + b.Minute);
            Console.WriteLine("Seconds:" + b.Second);
            Console.WriteLine("MilliSeconds:" + b.Millisecond);
            Console.ReadLine();
        }



    }

}
