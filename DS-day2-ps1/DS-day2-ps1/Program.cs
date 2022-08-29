using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DS_day2_ps1.StackImplementation;

namespace DS_day2_ps1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack1 = new Stack<string>();

            stack1.Push("Ram");
            stack1.Push("Ravi");
            stack1.Push("Kiran");
            stack1.Push("Teja");

            stack1.PrintStack();



            LinkedList<int> head = new LinkedList<int>(1);

            var v2 = new LinkedList<int>(2);

            head.AddAfter(v2);

            var v3 = new LinkedList<int>(3);

            v2.AddAfter(v3);

            while(head != null)
            {
                Console.WriteLine(head.Value);

                head = head.Next;
            }

            Console.ReadKey();

        }
    }
}
