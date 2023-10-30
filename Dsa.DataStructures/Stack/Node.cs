namespace Dsa.DataStructures.Stack
{
    public sealed class Node<T>
    {
        public T? Value { get; set; }

        public Node<T>? Previous { get; set; }
    }
}
