using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ps_3Structs
{
    struct Employee
    {
        public int empno;
        public string empname;
        public int empsal;
        public int depno;
    }

        internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1;

            emp1.empno = 12345;
            emp1.empname = "Hari krishna";
            emp1.empsal = 20000;
            emp1.depno = 54321;

            Console.ReadLine();
        }
    }
}
