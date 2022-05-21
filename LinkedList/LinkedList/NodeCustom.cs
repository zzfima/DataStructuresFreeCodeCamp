namespace LinkedList
{
    public class NodeCustom<T>
    {
        public T Value { get; set; }
        public NodeCustom<T> Next { get; set; }

        public NodeCustom(T val)
        {
            Value = val;
            Next = null;
        }
    }
}