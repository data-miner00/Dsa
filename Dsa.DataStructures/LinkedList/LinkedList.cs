namespace Dsa.DataStructures.LinkedList
{
    /// <summary>
    /// Singly linked list. Time complexity: O(n).
    /// </summary>
    /// <typeparam name="T">The homogeneous type to be stored.</typeparam>
    public sealed class LinkedList<T>
    {
        public int Length { get; set; } = 0;

        public Node<T>? Head { get; set; }

        public void Prepend(T item)
        {
            var node = new Node<T> { Value = item };

            if (this.Head == null)
            {
                this.Head = node;
                this.Length++;
                return;
            }

            var prevHead = this.Head;
            this.Head = node;
            node.Next = prevHead;
            this.Length++;
        }

        public void InsertAt(T item, int index)
        {
            if (this.Length < index)
            {
                throw new IndexOutOfRangeException();
            }

            var node = new Node<T> { Value = item };
            var currentNode = this.Head;

            for (var i = 0; i < index - 1; i++)
            {
                currentNode = currentNode.Next;
            }

            var nextNode = currentNode.Next;
            currentNode.Next = node;
            node.Next = nextNode;
            this.Length++;
        }

        public void Append(T item)
        {
            var node = new Node<T> { Value = item };
            var currentNode = this.Head;

            if (this.Head == null)
            {
                this.Head = node;
                this.Length++;
                return;
            }

            for (var i = 1; i < this.Length; i++)
            {
                currentNode = currentNode.Next;
            }

            currentNode.Next = node;
            this.Length++;
        }

        public T? Remove(T item)
        {
            var currentNode = this.Head;

            if (currentNode.Value.Equals(item))
            {
                this.Head = currentNode.Next;
                currentNode.Next = null;
                this.Length--;

                return currentNode.Value;
            }

            for (var i = 1; i < this.Length; i++)
            {
                if (currentNode.Next.Value.Equals(item))
                {
                    currentNode.Next = currentNode.Next.Next;
                    this.Length--;
                    return currentNode.Value;
                }
                currentNode = currentNode.Next;
            }

            return default;
        }

        public T? Get(int index)
        {
            if (index < 0 || index >= this.Length)
            {
                throw new IndexOutOfRangeException();
            }

            var currentNode = this.Head;

            for (var i = 0; i < index; i++)
            {
                currentNode = currentNode.Next;
            }

            return currentNode.Value;
        }

        public T? RemoveAt(int index)
        {
            var currentNode = this.Head;

            if (index == 0)
            {
                this.Head = currentNode.Next;
                currentNode.Next = null;
                this.Length--;
                return currentNode.Value;
            }

            for (var i = 0; i < index - 1; i++)
            {
                currentNode = currentNode.Next;
            }

            var nextNodeToBeDeleted = currentNode.Next;
            currentNode.Next = nextNodeToBeDeleted.Next;
            nextNodeToBeDeleted.Next = null;
            this.Length--;
            return nextNodeToBeDeleted.Value;
        }
    }
}
