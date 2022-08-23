using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ps_13_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] s = new int[] { 1, 3, 5, 200, 22, 2244, 213, 111 };

            List<int> result = new List<int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] > 100)
                {
                    result.Add(s[i]);

                }
            }

            var r = result.ToArray();

            foreach (var item in r)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();


        }
    }
}
