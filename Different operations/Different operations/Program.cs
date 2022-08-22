using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Different_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            Console.WriteLine("Enter the first number-");
            num1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Second number-");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the third number-");
            num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("result of first condition (x+y).z is:");
            int res = ((num1 + num2)*num3);
            Console.WriteLine(res);

            Console.WriteLine("result of second condition x.y + y.z. is:");
            int ress = (num1*num2 + num2*num3);
            Console.WriteLine(ress);

            Console.ReadLine();



        }
    }
}
