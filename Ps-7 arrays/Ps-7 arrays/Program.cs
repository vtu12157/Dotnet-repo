using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ps_7_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> luckynum = new Queue<int>();
            luckynum.Enqueue(1);
            luckynum.Enqueue(2);
            luckynum.Enqueue(3);
            luckynum.Enqueue(4);
            luckynum.Enqueue(5);

            Console.WriteLine("Elements before dequeue");
            foreach (var item in luckynum)
                Console.Write(item);
           

            luckynum.Dequeue();
            Console.WriteLine("\nElements after dequeue");
            foreach (var item in luckynum)
                Console.Write(item);

            Console.WriteLine("\nThe peek element is"+ luckynum.Peek());

            Console.ReadLine();


        }
    }
}
