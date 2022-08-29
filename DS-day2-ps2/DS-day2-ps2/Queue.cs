using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_day2_ps2
{
   
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

        
        public void Enqueue(int data)
        {
           
            if (capacity == rear)
            {
                Console.Write("\nQueue is full\n");
                return;
            }

           
            else
            {
                queue[rear] = data;
                rear++;
            }
            return;
        }

        
        public void Dequeue()
        {
            
            if (front == rear)
            {
                Console.Write("\nQueue is empty\n");
                return;
            }

            
            else
            {
                for (int i = 0; i < rear - 1; i++)
                {
                    queue[i] = queue[i + 1];
                }


                if (rear < capacity)
                    queue[rear] = 0;

               
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

          
            for (i = front; i < rear; i++)
            {
                Console.WriteLine( queue[i]);
            }
            return;
        }

    }


}
