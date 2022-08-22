using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr2 = new int[] { 10, 20, 50, 40, 78 };
            foreach(var item in arr2)
            {
                Console.WriteLine(item);
              
            }
            Console.ReadLine();
        }
    }
}
