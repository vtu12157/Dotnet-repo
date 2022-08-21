using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace you_look_older_than
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("enter your age");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("you look older than", age);
            Console.WriteLine(age);
            Console.ReadLine();
        }
    }
}
