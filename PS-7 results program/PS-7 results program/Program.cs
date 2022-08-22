using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace PS_7_results_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstsub,secondsub, thirdsub,TotalMarks, Percentage;
            
            Console.WriteLine("Enter the first subject marks");
            firstsub=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second subject marks");
            secondsub = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Third subject marks");
            thirdsub = Convert.ToInt32(Console.ReadLine());

            TotalMarks = firstsub + secondsub + thirdsub;

            Percentage = TotalMarks / 3;

            if (Percentage >= 60)
                Console.WriteLine("Result is first rank");
            else if (Percentage < 60 && Percentage >= 45)
                Console.WriteLine("Result is Second rank");
            else if (Percentage < 35 && Percentage >= 45)
                Console.WriteLine("Result is third rank");
            else if (Percentage < 35)
                Console.WriteLine("Result is fail");

            Console.ReadLine();




        }
    }
}
