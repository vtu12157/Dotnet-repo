using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ps_4_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var totalcount = 0;
            var arlist1 = new ArrayList();
            arlist1.Add("addin element1");
            arlist1.Add("addin element2");
            arlist1.Add("addin element3");
            arlist1.Add("addin element4");
            arlist1.Add("removing element");
            arlist1.Remove("removing element");
            foreach (string item in arlist1)
            {
                Console.WriteLine(item);
            }
            

            Console.WriteLine("Number of elements:" + arlist1.Count);

            Console.ReadLine();




        }
        
        
    }
}
