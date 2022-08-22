using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ps_11_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, sum = 0;
            Console.Write("numbers between 100 and 200");
            for(i=101; i<200; i++)
            {
                Console.Write("{0}",i);
                sum += i;
            }
            Console.Write("The sum:{0}", sum);
            Console.ReadLine();
        }
    }
}
