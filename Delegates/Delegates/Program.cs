using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    delegate void dele(string s);
    public class Program
    {
      
        static void Good(string s)
        {
            System.Console.WriteLine("  Good, {0}!", s);
        }

        static void Morning(string s)
        {
            System.Console.WriteLine("  Morning, {0}!", s);
        }

        static void Main()
        {
            dele firstdel, secondDel, multiDel;
            firstdel = Good;
            secondDel = Morning;
            multiDel = firstdel + secondDel;
            
            
            firstdel("\n");
           
            secondDel("\n");
           
            multiDel("");
           
            Console.ReadLine();
        }
    }
}

