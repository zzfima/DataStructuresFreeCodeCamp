using System;

namespace PriorityQueue
{
    internal class Node<T> where T : IComparable<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }
        public Node<T> Previous { get; set; }

        public Node(T v)
        {
            Value = v;

            Next = null;
            Previous = null;
        }
    }
}