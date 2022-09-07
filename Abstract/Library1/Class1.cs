using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library1
{
   public  abstract class person
    {
        public string Name { get; set; }
        public int age { get; set; }

        public int experience { get; set; }




        public abstract void Work();


    }
    public class Employee : person
    {
        public override void Work()
        {
            Console.WriteLine("this working person is an Employee");
        }

    }

    public class Manager : person
    {
        public override void Work()
        {
            Console.WriteLine("He manages a team");
        }
    }

   public  class clerk : person
    {
        public override void Work()
        {
            Console.WriteLine("the person is a clerk");
        }
    }



}
