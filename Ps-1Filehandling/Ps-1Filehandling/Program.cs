using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ps_1Filehandling
{
      class Program
    {
        static void Main(string[] args)
            
        {
            //Acessing directories in directories
            string rootpath = @"F:\Assignments";
            //string[] dirs= Directory.GetDirectories(rootpath, "*",SearchOption.AllDirectories);
            //foreach (string dir in dirs) 
            //{
            //    Console.WriteLine(dir);
            //}
            //Console.ReadLine();

            
            var files=Directory.GetFiles(rootpath,"*.*",SearchOption.AllDirectories);
            foreach (var file in files)
            {
                //Console.WriteLine(file);
                Console.WriteLine(Path.GetFileNameWithoutExtension(file));
            }
            Console.ReadLine();
        }
    }
}
