using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesPS_7
{
    public delegate void delegatepointer(string msg);
    internal class Program
    {
        static void Main(string[] args)
        {
            delegatepointer del1 = new delegatepointer(capofstr);
            del1("himavanth");
        }
        public static void capofstr(string strmsg)
        {
            if (strmsg.Length ==1)
                Console.WriteLine(char.ToUpper(strmsg[0]));
            else
                System.Console.WriteLine(char.ToUpper(strmsg[0]) + strmsg.Substring(1));

            Console.ReadLine();
        }
    }
}
