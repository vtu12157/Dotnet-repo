using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_day2_ps1
{
    internal class LinkedList<T>
    {
        public LinkedList( T value)
        {
            Value = value;
        }

        public LinkedList<T> Next { get; set; }

        public T Value { get; set; }

        public LinkedList<T> AddAfter(LinkedList<T> node)
        {
            Next = node;
            return node;
        }
    }
}
