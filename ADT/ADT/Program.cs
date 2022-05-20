using System;
using System.Collections.Generic;

namespace ADT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var c1 = new LinkedList<int>();
            c1.AddFirst(1);
            c1.AddFirst(2);
            c1.AddFirst(3);
            c1.AddFirst(4);
            foreach (var c in c1)
                Console.WriteLine(c);
            Console.WriteLine();

            ICollection<int> c2 = new LinkedList<int>();
            c2.Add(1);
            c2.Add(2);
            c2.Add(3);
            c2.Add(4);
            foreach (var c in c2)
                Console.WriteLine(c);
            Console.WriteLine();

            Queue<int> q1 = new Queue<int>();
            q1.Enqueue(1);
            q1.Enqueue(2);
            q1.Enqueue(3);
            q1.Enqueue(4);
            foreach (var q in q1)
                Console.WriteLine(q);
            Console.WriteLine();
        }
    }
}