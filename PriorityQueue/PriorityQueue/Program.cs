using System;

namespace PriorityQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(typeof(PriorityQueueVer1<>).Name);
            var queue1 = new PriorityQueueVer1<int>();
            queue1.Enqueue(52);
            queue1.Enqueue(42);
            queue1.Enqueue(53);
            while (queue1.IsEmpty == false)
            {
                Console.WriteLine(queue1.Dequeue());
            }

            Console.WriteLine(typeof(PriorityQueueVer2<>).Name);
            var queue2 = new PriorityQueueVer2<int>();
            queue2.Enqueue(22);
            queue2.Enqueue(12);
            queue2.Enqueue(33);
            queue2.Enqueue(14);
            while (queue2.IsEmpty == false)
            {
                Console.WriteLine(queue2.Dequeue());
            }
        }
    }
}