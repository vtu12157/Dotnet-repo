using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ps_3Indexof
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String s1,s2;
            s1 = "Hello all";
            Console.WriteLine(s1);
            

            int index1 = s1.IndexOf('H');
            Console.WriteLine("\nIndex of 'H'is:"+ index1);

            int index2 = s1.IndexOf('a');
            Console.WriteLine("\n Index of 'a' is:" + index2);

            int index3 = s1.IndexOf('z');
            Console.WriteLine("\n the index of'z' is:"+ index3);

            Console.ReadLine();


        }
    }
}
