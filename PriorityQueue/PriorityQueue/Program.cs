using System;

namespace PriorityQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var queue1 = new PriorityQueueVer1<int>();

            queue1.Enqueue(22);
            queue1.Enqueue(12);
            queue1.Enqueue(33);

            while (queue1.IsEmpty == false)
            {
                Console.WriteLine(queue1.Dequeue());
            }
        }
    }
}