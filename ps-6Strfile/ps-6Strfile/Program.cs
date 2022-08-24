using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ps_6Strfile
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string path = @"C:\Users\9966\source\repos1\simple.txt";

            using (StreamWriter sw = File.CreateText(path)) ;
            Console.ReadLine();

        }
    }
}
