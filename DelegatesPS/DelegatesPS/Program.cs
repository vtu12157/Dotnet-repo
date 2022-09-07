using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePS
{

    public delegate void delegatepointers(string msg);
    public class Program
    {
        static void Main(string[] args)
        {

            delegatepointers del1 = new delegatepointers(givingmsg);
            del1(" Aishwarya ");
        }

        public static void givingmsg(string n)
        {
            
           
            Console.WriteLine("Hello"+n+"!");

            Console.ReadLine();


        }
    }
}
