using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ps_5Struct
{
    struct Employee
    {
        public int empno;
        public string empname;
        public int empsal;
        public int depno;

        public void getdetails(int no, string name, int sal, int depno)
        {
            Console.WriteLine("Employee no: " + no);
            Console.WriteLine("Employee name: " + name);
            Console.WriteLine("Employee sal:" + sal);
            Console.WriteLine("Employee depno:" + depno);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee E1 = new Employee();
            Console.WriteLine("Enter Employee number");
            E1.empno =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Employee name:");
            E1.empname=Console.ReadLine();

            Console.WriteLine("Enter Employee salary:");
            E1.empsal=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Department number:");
            E1.depno=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Printing Employee details");
            int empno=E1.empno;
            Console.WriteLine(empno);
            Console.WriteLine(E1.empname);
            Console.WriteLine(E1.empsal);
            Console.WriteLine(E1.depno);


            Employee E2 = new Employee();
            Console.WriteLine("Enter Employee number");
            E2.empno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Employee name:");
            E2.empname = Console.ReadLine();

            Console.WriteLine("Enter Employee salary:");
            E2.empsal = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Department number:");
            E2.depno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Printing Employee details");
           
            Console.WriteLine(empno);
            Console.WriteLine(E2.empname);
            Console.WriteLine(E2.empsal);
            Console.WriteLine(E2.depno);

            Employee E3 = new Employee();
            Console.WriteLine("Enter Employee number");
            E3.empno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Employee name:");
            E3.empname = Console.ReadLine();

            Console.WriteLine("Enter Employee salary:");
            E3.empsal = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Department number:");
            E3.depno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Printing Employee details");

            Console.WriteLine(empno);
            Console.WriteLine(E3.empname);
            Console.WriteLine(E3.empsal);
            Console.WriteLine(E3.depno);

            Employee E4 = new Employee();
            Console.WriteLine("Enter Employee number");
            E4.empno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Employee name:");
            E4.empname = Console.ReadLine();

            Console.WriteLine("Enter Employee salary:");
            E4.empsal = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Department number:");
            E4.depno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Printing Employee details");

            Console.WriteLine(empno);
            Console.WriteLine(E4.empname);
            Console.WriteLine(E4.empsal);
            Console.WriteLine(E4.depno);
            Console.ReadLine();
            

        }
    }
}
