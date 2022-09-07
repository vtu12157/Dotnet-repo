using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePs_1
{

    public delegate void delegatepointer(string msg);
    public class Program
    {
        static void Main(string[] args)
        {

            delegatepointer del1 = new delegatepointer(sizeofthestr);
            del1("this is the string for which length is calculated");
        }

        public static void sizeofthestr(string strmsg)
        {
            int s = strmsg.Length;
            Console.WriteLine("The length of string is {0}",s);

            Console.ReadLine();


        }
    }
}
