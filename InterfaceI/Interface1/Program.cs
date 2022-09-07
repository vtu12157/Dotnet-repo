using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            savings s = new savings();
            s.printbalance();
            int v = s.calculateinterest();

           

            Console.WriteLine(v);
            s.Deposit(1000);
            Console.WriteLine("Deposited 1000");

            Console.WriteLine("---with drawing 500----");
            s.withdraw(500);

            Console.WriteLine("last updated "+s.d);


            current c = new current();
            c.printbalance();
            int m = c.calculateinterest();
            Console.WriteLine(m);

            Console.WriteLine("With drawing 500");
            c.withdraw(500);
            c.Depositing(10000);
            Console.WriteLine("10000 is deposited");
            Console.WriteLine("last updated " + c.d1);





            Console.ReadLine();


        }
    }
}
