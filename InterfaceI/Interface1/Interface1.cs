using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface1
{
    public interface IBank
    {
        void printbalance();
         int calculateinterest();

    }

     public class savings: IBank
    {
        public DateTime d = new DateTime(2019,02,03);
        
       public void printbalance()
        {
            Console.WriteLine("The balance is " + b1);
        }

       public int calculateinterest()
        { return b1/ Interestrate; }
        public int b1 = 200000;
        public int Interestrate = 4;
    }

    public class current:IBank
    {
        public DateTime d1 = new DateTime(2019, 02, 03);
        public void printbalance()
        {
            Console.WriteLine("The balance is " + B);
        }

        public int calculateinterest()
        { return B/Interestrate; }

        public int B = 15000;

        public int Interestrate = 2;

        
    }

}
