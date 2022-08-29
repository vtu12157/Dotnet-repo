using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ps_4DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
          LinkedList<string> list = new LinkedList<string>();
            list.AddLast("hari");
            list.AddLast("shiva");
            list.AddLast("jam");
            var n = list.AddLast("jim");
            list.AddAfter(n,"john");
            list.AddBefore(n, "neel");
            list.AddFirst("hima");

            Console.WriteLine("Next :" + n.Next.Value);

            Console.WriteLine("Prev: " + n.Previous.Value);

            list.Find("jam");

            foreach(var item in list)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
