using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_day2_ps2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();

            q.Enqueue(1);

            q.Enqueue(2);

            q.Enqueue(3);

            q.Enqueue(4);

            q.queueDisplay();

            Console.ReadKey();
        }
    }
}
