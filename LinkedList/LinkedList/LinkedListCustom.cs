using System.Collections;
using System.Collections.Generic;

namespace LinkedList
{
    internal class LinkedListCustom<T> : IEnumerator<T>, IEnumerable<T>
    {
        private NodeCustom<T> _headNode;
        private NodeCustom<T> _current;

        public LinkedListCustom()
        {
            _headNode = null;
        }

        public T Current => _current.Value;

        object IEnumerator.Current => _current.Value;

        public void Remove(T val)
        {
            if (_headNode == null)
                return;

            NodeCustom<T> n = _headNode;
            while (true)
            {
                if (EqualityComparer<T>.Default.Equals(n.Value, val))
                {
                    NodeCustom<T> n1 = _headNode;
                    while (true)
                    {
                        if (n == n1.Next)
                        {
                            n1.Next = n.Next;
                            return;
                        }

                        n1 = n1.Next;
                    }
                }

                n = n.Next;
            }
        }

        public void Add(T val)
        {
            if (_headNode == null)
            {
                _headNode = new NodeCustom<T>(val);
                _headNode.Next = null;
            }
            else
            {
                var n = _headNode;
                while (true)
                {
                    //find end of list
                    if (n.Next == null)
                    {
                        n.Next = new NodeCustom<T>(val);
                        break;
                    }

                    n = n.Next;
                }
            }
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public bool MoveNext()
        {
            if (_current.Next == null)
                return false;
            _current = _current.Next;
            return true;
        }

        public void Reset()
        {
            _current = _headNode;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            var n = _headNode;
            while (n != null)
            {
                //find end of list

                yield return n.Value;
                n = n.Next;
            }
        }

        public void Insert(T val, int place)
        {
            var n = _headNode;
            for (int i = 0; i < place; i++)
                n = n.Next;

            var newNode = new NodeCustom<T>(val);
            newNode.Next = n.Next;

            n.Next = newNode;
        }
    }
}