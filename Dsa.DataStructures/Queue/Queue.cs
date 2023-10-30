namespace Dsa.DataStructures.Queue
{
    /// <summary>
    /// The queue data structure.
    /// </summary>
    /// <typeparam name="T">The type of data.</typeparam>
    public sealed class Queue<T>
    {
        public int Length { get; private set; } = 0;

        public Node<T>? Head { get; private set; }

        public Node<T>? Tail { get; private set; }

        public void Enqueue(T value)
        {
            var node = Node<T>.Create(value);

            this.Length++;

            if (this.Head == null || this.Tail == null)
            {
                this.Head = this.Tail = node;
                return;
            }

            this.Tail.Next = node;
            this.Tail = node;
        }

        public T? Dequeue()
        {
            if (this.Head == null)
            {
                return default;
            }

            this.Length--;

            var head = this.Head;

            this.Head = head.Next;

            head.Next = null;

            if (this.Length == 0)
            {
                this.Tail = null;
            }

            return head.Value;
        }

        public T? Peek()
        {
            if (this.Head == null)
            {
                return default;
            }

            return this.Head.Value;
        }
    }
}
