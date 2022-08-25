using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ps_6Structs
{
    public enum Deptnames
    {
        Purchase=1,
        Sales=2,
        Training=3,
        Accounts=4,
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Deptnames test = Deptnames.Sales;
            Console.WriteLine((int)test);
            Console.ReadLine();
        }
    }
}
