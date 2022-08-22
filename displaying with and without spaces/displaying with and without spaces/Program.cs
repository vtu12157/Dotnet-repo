using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace displaying_with_and_without_spaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter a digit:");
            num=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} {0} {0} {0}",num);


            Console.WriteLine("{0}{0}{0}{0}", num);
            Console.ReadLine();
        }
    }
}
