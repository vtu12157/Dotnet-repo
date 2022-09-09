using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadingPS_3
{
    public class priorityofthread
    {
        public static void M()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Print  i= " + i);
                Console.WriteLine("Thread name =" + Thread.CurrentThread.Name);

                Thread.Sleep(300);
            }
        }

        static void Main(string[] args)
        {
            Thread T = new Thread(M);
            T.Name = "first";
            Thread T1 = new Thread(M);
            T1.Name = "second";
            Thread T2 = new Thread(M);
            T2.Name = "third";
            T1.Priority = ThreadPriority.Highest;
            T.Priority = ThreadPriority.Normal;
             T2.Priority = ThreadPriority.Lowest;
            T1.Start();
            T.Start();
            T2.Start();
            Console.ReadLine();
        }
    }
}
