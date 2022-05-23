using System;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedListCustom<int> linkedListCustom = new LinkedListCustom<int>();
            linkedListCustom.Add(5);
            linkedListCustom.Add(6);
            linkedListCustom.Add(7);
            linkedListCustom.Add(8);
            linkedListCustom.Insert(8, 2);
            linkedListCustom.Insert(18, 2);
            linkedListCustom.Insert(28, 2);

            linkedListCustom.Remove(7);

            foreach (var v in linkedListCustom)
            {
                Console.WriteLine(v);
            }

            Console.ReadLine();
        }
    }
}