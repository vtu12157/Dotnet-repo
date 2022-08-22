using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS_9_sum_of_odd_natural_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, n, sum = 0;
            Console.Write("Enter number of terms:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("The odd numbers are:");
            for(i=1;i<=n;i++)
            {
                Console.Write("{0}", 2 * i - 1);
                sum += 2 * i - 1;

            }

            Console.Write("\nThe sum of the numbers are");
            Console.Write(sum);
            Console.ReadLine();
        }
    }
}
