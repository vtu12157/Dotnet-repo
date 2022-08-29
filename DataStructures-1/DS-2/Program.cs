using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datastructures_lib;

namespace DS_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employeestruct[] empStrc = new Employeestruct[2];

            for (int i = 0; i < empStrc.Length; i++)
            {
                empStrc[i] = new Employeestruct();
                Console.WriteLine("Enter Empid");
                empStrc[i].EmpID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Empname");
                empStrc[i].EmpName = Console.ReadLine();
                Console.WriteLine("Enter Deptno");
                empStrc[i].DeptNo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter City");
                empStrc[i].City = Console.ReadLine();
                Console.WriteLine("enter basic salary");
                int bs = Convert.ToInt32(Console.ReadLine());
                empStrc[i].CalculateSalary(bs);
            }
            Console.WriteLine("----------------------");

            foreach (var item in empStrc)
            {
                Console.WriteLine("Following are the details");
                Console.WriteLine(item.EmpID);
                Console.WriteLine(item.EmpName);
                Console.WriteLine(item.DeptNo);
                Console.WriteLine(item.City);
                Console.WriteLine(item.GrossSalary);
                Console.ReadLine();
            }
        }
    }
}
