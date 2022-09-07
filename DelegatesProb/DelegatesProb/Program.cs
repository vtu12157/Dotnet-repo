using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesProb
{
    public delegate void delegatepointer(int num1, int num2);
    public class Program
    {
        static void Main(string[] args)
        {
            delegatepointer del1 = new delegatepointer(arithops);
            del1(3, 4);
        }

        public static void arithops(int n1,int n2)
        {
           

            Console.WriteLine("{0} + {1} = {2}", n1, n2, n1 + n2);
            Console.WriteLine("{0} - {1} = {2}", n1, n2, n1 - n2);
            Console.WriteLine("{0} x {1} = {2}", n1, n2, n1 * n2);
            Console.WriteLine("{0} / {1} = {2}", n1, n2, n1 / n2);
            Console.WriteLine("{0} mod {1} = {2}", n1, n2, n1 % n2);

            Console.ReadLine();
        }
    }
}
