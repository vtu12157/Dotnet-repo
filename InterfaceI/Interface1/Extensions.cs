using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface1
{
    public static class Extensions
    {
        public static void withdraw(this savings  s, int amount)
        {
            s.b1 -= amount;
            s.printbalance();
        }

        public static void withdraw(this current s, int amount)
        {
            s.B -= amount;
            s.printbalance();
        }

        public static void Deposit(this savings s, int amount)
        {
            s.b1 +=amount;
            s.printbalance();
        }
        public static void Depositing(this current s, int amount)
        {
            s.B += amount;
            s.printbalance();
        }

    }
}
