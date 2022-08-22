using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 9, 7, 4, 6, 2, 5, 1, 8 };
            foreach (int a in arr)
            {
                Console.WriteLine(a);
            }
            Array.Reverse(arr);
            Console.WriteLine("Reverse array:");
            foreach(int value in arr)
            { 
                Console.WriteLine(value);
            }
            Console.ReadLine();

        }
    }
}
