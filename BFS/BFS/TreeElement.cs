using System.Collections.Generic;

namespace BFS
{
    public class TreeElement<T>
    {
        public int Level { get; set; }
        public T Value { get; set; }
        public IList<TreeElement<T>> Neighbors { get; set; }

        public TreeElement(T val)
        {
            Value = val;
            Neighbors = new List<TreeElement<T>>();
            Level = -1;
        }
    }
}