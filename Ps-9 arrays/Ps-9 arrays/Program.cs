using System;
using System.Collections;
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

            var fltlist = new ArrayList();
            fltlist.Add(3.5);
            fltlist.Add(4.9);
            fltlist.Add(8.5);
            fltlist.Add(6.5);
            fltlist.Sort();

            foreach (var val in fltlist)
                Console.WriteLine(val);
            Console.WriteLine("\n descending order is:");
            fltlist.Reverse();

            foreach (var val in fltlist)
                Console.WriteLine(val);


            Console.ReadLine();
        }
    }

}
    

