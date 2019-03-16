namespace Iterator
{
    public class LinkedListNode<T>
    {
        public LinkedListNode(T data, LinkedListNode<T> next)
        {
            this.Data = data;
            this.Next = next;
        }

        public T Data { get; set; }
        public LinkedListNode<T> Next { get; set; }
    }
}