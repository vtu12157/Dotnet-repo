using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library1
{
    public class Dept
    {
        public delegate void AddDelegate(Employee emp);

        public delegate void RemoveDelegate(int empID);

        public delegate void UpdateDelegate(Employee emp);

        public event AddDelegate AddEvent;

        public event RemoveDelegate RemoveEvent;

        public event UpdateDelegate UpdateEvent;

        public Dept()
        {
            Employees = new List<Employee>();
            //registration
            AddEvent += new AddDelegate(Emp_AddEvent);
            RemoveEvent += new RemoveDelegate( Emp_RemoveEvent);
            UpdateEvent += new UpdateDelegate(Emp_UpdateEvent);
        }

        public void RaiseAddEvent(Employee emp)
        {
            AddEvent.Invoke(emp);
        }

        public void RaiseUpdateEvent(Employee emp)
        {
            UpdateEvent.Invoke(emp);
        }

        public void RaiseDeleteEvent(int empID)
        {
            RemoveEvent.Invoke(empID);
        }

        private void Emp_UpdateEvent(Employee emp)
        {
          var obj =  Employees.FirstOrDefault(x => x.Employeeid == emp.Employeeid);

            obj.deptno = emp.deptno;
            obj.manager =  emp.manager;
            obj.Employeename = emp.Employeename;
        }

        private void Emp_RemoveEvent(int empID)
        {
            Employees.RemoveAll(  x=> x.Employeeid == empID);
        }

        private void Emp_AddEvent(Employee emp)
        {
            Employees.Add(emp);
        }

        public int Deptno { get; set; }
        public string DeptName { get; set; }
        public string DeptLocation { get; set; }    

        public List<Employee> Employees { get; set; }

    }

    public class Employee
    {
        public int Employeeid { get; set; }
        public string Employeename { get; set; }

        public int deptno { get; set; }
        public int salary { get; set; } 
        public string manager { get; set; }
    }
    
    
}
