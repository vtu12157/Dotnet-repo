using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library1;

namespace Abstract
{
    class program
    {
        static void Main(string[] args)
        {
            clerk clerk1 = new Library1.clerk();
            clerk1.Work();
            

            Manager tim =new Manager();
            tim.Work();
           

            Employee john = new Employee();
            john.Work();
            Console.ReadLine();
        }
    }
}

