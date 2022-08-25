using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ps_4Struct
{
    struct Employee
    {
        public int empno;
        public string empname;
        public int empsal;
        public int depno;

        public void getdetails(int no,string name,int sal,int depno)
        {
            Console.WriteLine("Employee no: " + no);
            Console.WriteLine("Employee name: " + name);
            Console.WriteLine("Employee sal:"+sal);
            Console.WriteLine("Employee depno:" + depno);
        }
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

            emp1.getdetails(emp1.empno, emp1.empname, emp1.empsal, emp1.depno);

            Console.ReadLine();


    }
        }
}
