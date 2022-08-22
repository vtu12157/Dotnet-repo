using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS_3_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            int i, n, sum = 0;
            Console.Write("Enter elements for storing in the array");
            n=Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array:\n", n);
            for(i=0;i<n;i++)
            {
                Console.Write("element-{0}:",i);
                a[i]=Convert.ToInt32(Console.ReadLine());
            }
            for(i=0;i<n;i++)
            {
                sum += a[i];
            }
            Console.Write("sum of elements is:{0}", sum);
            Console.ReadLine();
        }
    }
}
