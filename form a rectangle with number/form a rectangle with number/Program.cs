using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace form_a_rectangle_with_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;

            Console.Write("Enter the number:");
            x=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}{0}{0}",x);
            Console.WriteLine("{0}  {0}", x);
            Console.WriteLine("{0}  {0}", x);
            Console.WriteLine("{0}  {0}", x);
            Console.WriteLine("{0}  {0}", x);
            Console.WriteLine("{0}{0}{0}", x);
            Console.ReadLine();

        }
    }
}
