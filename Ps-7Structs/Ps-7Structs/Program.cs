using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemo
{
    class Program
    {
        public static void Main(String[] args)
        {
            try
            {
                int a = 20;
                int b = 0;
                int div = a / b;
                Console.WriteLine("div="+div);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Stack Trace=" + ex.StackTrace);
                Console.WriteLine("------");
                ex.Source = "Exception Handling Demo";
                Console.WriteLine("Source=  " + ex.Source);
                Console.WriteLine("-------");
                Console.WriteLine("Message" + ex.Message);
            }
            Console.ReadLine();
            

        }
    }

}