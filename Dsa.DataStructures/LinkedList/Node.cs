namespace Dsa.DataStructures.LinkedList
{
    public sealed class Node<T>
    {
        public static Node<T> Create(T item) => new() { Value = item };
        
        public T? Value { get; set; }

        public Node<T>? Next { get; set; }
    }
}
