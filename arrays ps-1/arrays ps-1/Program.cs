using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace arrays_ps_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int i;
            Console.Write("Elements of the array:\n");
            Console.Write("Input the elements of the array\n");
            for(i=0;i<10;i++)
            {
                Console.Write("arrayelem-{0}  ",  i);
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Array elements are:");
            for (i = 0; i < 10; i++)
            {
                Console.Write("{0}   ", arr[i]);
            }
            Console.ReadLine();
        }
    }
}
