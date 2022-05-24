using System;
using System.Collections.Generic;

namespace BFS
{
    static class TraverseTreeBFS
    {
        static int level = 0;

        public static void Traverse(Queue<TreeElement<int>> elements)
        {
            level++;

            Queue<TreeElement<int>> queue = new Queue<TreeElement<int>>();

            foreach (var element in elements)
            {
                foreach (var neighbor in element.Neighbors)
                {
                    if (neighbor.Level == -1)
                    {
                        neighbor.Level = level + 1;
                        Console.WriteLine($"value {neighbor.Value} at level {neighbor.Level}");
                        queue.Enqueue(neighbor);
                    }
                }
            }

            if (queue.Count > 0)
                Traverse(queue);
        }
    }
}