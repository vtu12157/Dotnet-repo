using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ps_10_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();

            dic.Add(1, "Ram");
            dic.Add(2, "Cat");

            Console.WriteLine(dic[1]);

            Console.WriteLine(dic[2]);

            Console.ReadLine();

        }
    }
}
