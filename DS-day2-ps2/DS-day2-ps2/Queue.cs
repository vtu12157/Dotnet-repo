using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_day2_ps2
{
    // C# program to implement a queue using an array
    using System;

    public class Queue
    {
        private int front, rear, capacity;
        private int[] queue;

        public Queue()
        {
            front = rear = 0;
            capacity = 1000;
            queue = new int[capacity];
        }

        // function to insert an element
        // at the rear of the queue
        public void Enqueue(int data)
        {
            // check queue is full or not
            if (capacity == rear)
            {
                Console.Write("\nQueue is full\n");
                return;
            }

            // insert element at the rear
            else
            {
                queue[rear] = data;
                rear++;
            }
            return;
        }

        // function to delete an element
        // from the front of the queue
        public void Dequeue()
        {
            // if queue is empty
            if (front == rear)
            {
                Console.Write("\nQueue is empty\n");
                return;
            }

            // shift all the elements from index 2 till rear
            // to the right by one
            else
            {
                for (int i = 0; i < rear - 1; i++)
                {
                    queue[i] = queue[i + 1];
                }

                // store 0 at rear indicating there's no element
                if (rear < capacity)
                    queue[rear] = 0;

                // decrement rear
                rear--;
            }
            return;
        }

        public void queueDisplay()
        {
            int i;
            if (front == rear)
            {
                Console.Write("\nQueue is Empty\n");
                return;
            }

            // traverse front to rear and print elements
            for (i = front; i < rear; i++)
            {
                Console.WriteLine( queue[i]);
            }
            return;
        }

    }


}
