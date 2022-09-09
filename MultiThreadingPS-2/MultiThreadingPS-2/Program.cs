using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadingPS_2
{
    public class Stateofthread
    {
        public static void Method()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Name="+Thread.CurrentThread.Name);
        }
        static void Main(string[] args)
        {
            Thread T= new Thread(Method);
            Console.WriteLine("Before starting");
            Console.WriteLine("Threadstate="+  T.ThreadState);
            Console.ReadKey();
        }
    }
}
