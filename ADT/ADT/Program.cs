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

            ICollection<int> c2 = new LinkedList<int>();
            c2.Add(1);
            c2.Add(2);
            c2.Add(3);
            c2.Add(4);

            foreach (var c in c2)
                Console.WriteLine(c);
        }
    }
}