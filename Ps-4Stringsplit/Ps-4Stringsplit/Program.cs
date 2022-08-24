using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ps_4Stringsplit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String mystring = "Welcome to the world of C# Programming";

            string[] splittedone = mystring.Split('#');
            foreach(string s3 in splittedone)
            {
                Console.WriteLine(s3);
            }
            Console.ReadLine();


        }
    }
}
