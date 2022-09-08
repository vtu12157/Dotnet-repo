using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library1;

namespace deptcls
{
    internal class Program
    {

        delegate void DisplayEmployees(List<Employee> employees);

        static void Main(string[] args)
        {



            Dept dept = new Dept();

            dept.RaiseAddEvent(new Employee() { Employeeid = 1, deptno = 1,Employeename = "Ram" , manager = "Kiran" });

            dept.RaiseAddEvent(new Employee() { Employeeid = 2, deptno = 1, Employeename = "Peter", manager = "Rob" });

            dept.RaiseUpdateEvent(new Employee() { Employeeid = 2, deptno = 1, Employeename = "Peter1", manager = "Rob1" });

            dept.RaiseDeleteEvent(1);

            dept.RaiseAddEvent(new Employee() { Employeeid = 1, deptno = 1, Employeename = "Ram", manager = "Kiran" });

            DisplayEmployees displayEmployees = DisplayEmployees1;

            displayEmployees.Invoke(dept.Employees);

            //func , Action, Predicate


            Console.WriteLine("");
            Action<List<Employee>> action = DisplayEmployeesAndManagers;
            Func<Employee,bool> predicate = x => x.manager != null;

            action.Invoke(dept.Employees.Where(predicate).ToList());
            Console.ReadKey();

        }

        public static void DisplayEmployees1(List<Employee> employees)
        {
            foreach (var employee in employees)
            {
                Console.WriteLine( "Name: " + employee.Employeename);
                Console.WriteLine("Manager: " + employee.manager);
                Console.WriteLine("DeptNo: " + employee.deptno);
                Console.WriteLine("ID: " + employee.Employeeid);
                Console.WriteLine("Salary: " + employee.salary);
                Console.WriteLine("-----------------------------");
            }

        }

        public static void DisplayEmployeesAndManagers(List<Employee> employees)
        {
            foreach (var employee in employees)
            {
                Console.WriteLine("Name: " + employee.Employeename);
                Console.WriteLine("Manager: " + employee.manager);
                Console.WriteLine("-----------------------------");
            }

        }
    }
}
