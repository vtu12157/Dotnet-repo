using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading;

namespace MultiThreadingPS_1
{
    public class Program
    {
        public static void n()
        {
            for(int i=0;i<=10;i++)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            Thread mythread = new Thread(n);
            mythread.Start();
            Console.ReadLine();
        }
    }
}
