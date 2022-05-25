using System;
using System.Collections.Generic;

namespace BFS
{
    internal class TraverseTreeBFSVer2<T>
    {
        private readonly TreeElement<T> _head;
        private readonly Queue<TreeElement<T>> _queue;

        public TraverseTreeBFSVer2(TreeElement<T> head)
        {
            _queue = new Queue<TreeElement<T>>();
            _queue.Enqueue(head);
        }

        public void Traverse()
        {
            if (_queue.Count == 0)
                return;

            var element = _queue.Dequeue();
            element.Level = 5;
            Console.WriteLine(element.Value);
            foreach (var neighbor in element.Neighbors)
            {
                if (neighbor.Level == -1)
                    _queue.Enqueue(neighbor);
            }

            Traverse();
        }
    }
}