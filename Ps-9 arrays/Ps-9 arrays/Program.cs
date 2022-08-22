using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ps_9_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using System;
            using System.Collections.Generic;
namespace prob6
    {
        internal class Program
        {

            static void Main(string[] args)
            {
                Stack<int> st = new Stack<int>();

                st.Push(10);
                st.Push(205);
                st.Push(300);
                st.Push(400);
                st.Push(500);
                Console.WriteLine($"No.of.elements in stack: {st.Count}");
                Console.WriteLine("STACK ELEMENTS");
                foreach (var item in st)
                {
                    Console.WriteLine(item + '\t');
                }
                Console.WriteLine($"top element:{st.Peek()}");
                st.Pop();
                st.Pop();
                Console.WriteLine($"top element:{st.Peek()}");
                Console.ReadLine();
            }
        }
    }

}
    }
}
