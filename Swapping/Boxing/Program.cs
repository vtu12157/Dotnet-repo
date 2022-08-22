using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 5, b = 6;
            Console.WriteLine("before swapping a=" + a + "b=" + b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("after swapping a="  + a + "b=" + b);



            Console.ReadLine();


        }
    }
}