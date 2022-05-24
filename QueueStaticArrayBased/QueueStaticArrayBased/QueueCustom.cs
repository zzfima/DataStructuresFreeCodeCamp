using System;
using System.Collections;
using System.Collections.Generic;

namespace QueueStaticArrayBased
{
    public class QueueCustom<T> : IEnumerable<T>
    {
        private T[] _array;
        private int _queueLength;

        public QueueCustom()
        {
            _array = new T[4];
            _queueLength = 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            int cnt = 0;
            while (cnt < _queueLength)
                yield return _array[cnt++];
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Enqueue(T v)
        {
            if (_queueLength == _array.Length)
                Resize();

            _array[_queueLength++] = v;
        }

        private void Resize()
        {
            int newLength = _array.Length * 2;
            T[] newArray = new T[newLength];
            Array.Copy(_array, 0, newArray, 0, _queueLength);
            _array = newArray;
        }

        public T Dequeue()
        {
            T v = _array[0];

            for (int i = 0; i < _queueLength; i++)
                _array[i] = _array[i + 1];

            _queueLength--;
            return v;
        }
    }
}