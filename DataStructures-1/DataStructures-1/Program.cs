﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datastructures_lib;
using Datastructureslib;

namespace DataStructures_1
{
    internal class Program
    {

        static void Main(string[] args)

        {
            string Emp;
            Employee[] emp = new Employee[2];

            for (int i = 0; i < emp.Length; i++)
            {
                emp[i] = new Employee();
                Console.WriteLine("Enter Empid");
                emp[i].EmpID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Empname");
                emp[i].EmpName = Console.ReadLine();
                Console.WriteLine("Enter Deptno");
                emp[i].DeptNo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter City");
                emp[i].City = Console.ReadLine();
                Console.WriteLine("enter basic salary");
                int bs = Convert.ToInt32(Console.ReadLine());
                emp[i].CalculateSalary(bs);
            }
            Console.WriteLine("----------------------");

            foreach (var item in emp)
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

