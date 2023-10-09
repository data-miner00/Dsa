namespace Dsa.DataStructures.Stack
{
    public sealed class Node<T>
    {
        public T? Value { get; set; }

        public Node<T>? Previous { get; set; }
    }

    public sealed class Stack<T>
    {
        public uint Length { get; set; } = 0;

        private Node<T>? Head { get; set; }

        public void Push(T item)
        {
            var node = new Node<T> { Value = item };
            this.Length++;

            if (this.Head == null)
            {
                this.Head = node;
                return;
            }

            node.Previous = this.Head;
            this.Head = node;
        }

        public T? Pop()
        {
            this.Length = Math.Max(0, this.Length - 1);

            var head = this.Head;

            if (this.Length == 0)
            {
                this.Head = null;
                return head.Value;
            }

            this.Head = head.Previous;

            return head.Value;
        }

        public T? Peek()
        {
            return this.Head.Value;
        }
    }
}
