using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_day2_ps1
{
    using System;

    namespace StackImplementation
    {
        public class Stack<T>
        {
            static readonly int MAX = 1000;
            int top;
            T[] stack = new T[MAX];

            bool IsEmpty()
            {
                return (top < 0);
            }
            public Stack()
            {
                top = -1;
            }
            internal bool Push(T data)
            {
                if (top >= MAX)
                {
                    Console.WriteLine("Stack Overflow");
                    return false;
                }
                else
                {
                    stack[++top] = data;
                    return true;
                }
            }

            internal T Pop()
            {
                if (top < 0)
                {
                    Console.WriteLine("Stack Underflow");
                    throw new Exception("Stack Underflow");
                }
                else
                {
                    T value = stack[top--];
                    return value;
                }
            }

            internal T Peek()
            {
                if (top < 0)
                {
                    Console.WriteLine("Stack Underflow");
                    throw new Exception("Stack Underflow");
                }
                else
                    return stack[top];
            }

            internal void PrintStack()
            {
                if (top < 0)
                {
                    Console.WriteLine("Stack Underflow");
                    return;
                }
                else
                {
                    Console.WriteLine("Items in the Stack are :");
                    for (int i = top; i >= 0; i--)
                    {
                        Console.WriteLine(stack[i]);
                    }
                }
            }


        }

       
    }

}


