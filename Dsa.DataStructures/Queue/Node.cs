namespace Dsa.DataStructures.Queue
{
    public sealed class Node<T>
    {
        public static Node<T> Create(T value) => new() { Value = value };

        public T Value { get; set; }

        public Node<T>? Next { get; set; }
    }
}
