using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ps_6_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> intstack = new Stack<int>();
            intstack.Push(1);
            intstack.Push(2);   
            intstack.Push(3);
            intstack.Push(4);
            intstack.Push(5);

            Console.WriteLine("Elements before popping");
            foreach (var item in intstack)
                
                Console.Write(item + ",");
            intstack.Pop();
            Console.WriteLine("\nElements after popping");
            foreach (var item in intstack)

                Console.Write(item + ",");
            Console.WriteLine("\npeek element is "  +  intstack.Peek());
            Console.WriteLine("\n count of elements are"+intstack.Count());

            Console.ReadLine();
            
        }
    }
}
