using System;
using System.Collections.Generic;
using System.Linq;

namespace PriorityQueue
{
    public class PriorityQueueVer1<T> where T : IComparable<T>
    {
        private readonly SortedSet<T> _queueArray;

        public PriorityQueueVer1()
        {
            _queueArray = new SortedSet<T>();
        }

        public bool IsEmpty => _queueArray.Count == 0;

        public void Enqueue(T v)
        {
            _queueArray.Add(v);
        }

        public T Dequeue()
        {
            if (IsEmpty)
                throw new Exception("PQ Is empty");

            var v = _queueArray.Last();
            _queueArray.Remove(v);
            return v;
        }
    }
}