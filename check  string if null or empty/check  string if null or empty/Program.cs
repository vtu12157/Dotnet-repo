using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace check__string_if_null_or_empty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            string s1 = "hello";
            string s3 = null;

            bool b = string.IsNullOrEmpty(s);
            bool b1 = string.IsNullOrEmpty(s1);
            bool b2 = string.IsNullOrEmpty(s3);
            Console.WriteLine(b);
            Console.WriteLine(b1);
            Console.WriteLine(b2);
            Console.ReadLine();
        }
    }
}
