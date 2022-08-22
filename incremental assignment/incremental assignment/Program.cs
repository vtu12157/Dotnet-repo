using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace incremental_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first name:");
            string FirstName=Console.ReadLine();

            Console.WriteLine("Enter the last name:");
            string SecondName = Console.ReadLine();

            Console.WriteLine("Welcome to my app {0}{1}", FirstName ,SecondName);
            Console.ReadLine();
        }
    }
}
