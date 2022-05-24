using System;

namespace QueueStaticArrayBased
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QueueCustom<int> queue = new QueueCustom<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            foreach (int v in queue)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine(queue.Dequeue());

            foreach (int v in queue)
            {
                Console.WriteLine(v);
            }
        }
    }
}