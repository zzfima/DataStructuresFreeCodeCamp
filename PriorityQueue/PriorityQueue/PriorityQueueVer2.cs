using System;
using System.Collections.Generic;

namespace PriorityQueue
{
    internal class PriorityQueueVer2<T> where T : IComparable<T>
    {
        private Node<T> _head;
        private Node<T> _tail;
        public int Length { get; private set; }

        public PriorityQueueVer2()
        {
            _head = null;
            _tail = null;
            Length = 0;
        }

        public bool IsEmpty => Length == 0;

        public void Enqueue(T v)
        {
            if (Length == 0)
            {
                var newHead = new Node<T>(v);
                _head = newHead;
                Length++;
                return;
            }
            else if (Length == 1)
            {
                var newTail = new Node<T>(v);
                _tail = newTail;
                _head.Next = _tail;
                _tail.Previous = _head;
                Length++;
                if (_head.Value.CompareTo(_tail.Value) > 0)
                {
                    (_head.Value, _tail.Value) = (_tail.Value, _head.Value);
                }
            }
            else
            {
                var currentNode = _head;
                while (currentNode != null)
                {
                    if (currentNode.Next == null) //put at end of queue, is biggest one
                    {
                        _tail = new Node<T>(v);

                        currentNode.Next = _tail;
                        _tail.Previous = currentNode;

                        Length++;
                        return;
                    }

                    if (currentNode.Value.CompareTo(v) < 0)
                    {
                        if (currentNode.Next.Value.CompareTo(v) < 0)
                            currentNode = currentNode.Next;
                        else
                        {
                            var newElem = new Node<T>(v);
                            var nextElem = currentNode.Next;

                            currentNode.Next = newElem;
                            newElem.Previous = currentNode;
                            newElem.Next = nextElem;
                            nextElem.Previous = newElem;
                            Length++;
                            return;
                        }
                    }
                }
            }

            //var cnt = 0;
            //while (true)
            //{
            //    if (EqualityComparer<T>.Default.Equals(_queueArray[cnt].Next.Value, v))
            //        cnt++;
            //}
        }

        public T Dequeue()
        {
            if (IsEmpty)
                throw new Exception("PQ Is empty");

            if (Length == 2) //go remove tail
            {
                var v = _tail.Value;
                _tail = null;
                _head.Next = null;
                Length--;
                return v;
            }
            else if (Length == 1) //go remove head
            {
                var v = _head.Value;
                _head = null;
                Length--;
                return v;
            }
            else
            {
                var v = _tail.Value;
                _tail = _tail.Previous;

                Length--;
                return v;
            }
        }
    }
}