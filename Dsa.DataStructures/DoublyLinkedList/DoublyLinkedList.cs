namespace Dsa.DataStructures.DoublyLinkedList
{
    /// <summary>
    /// Doubly linked list. Time complexity: O(n).
    /// </summary>
    /// <typeparam name="T">The homogeneous type to be stored.</typeparam>
    public sealed class DoublyLinkedList<T>
    {
        public int Length { get; private set; } = 0;

        public Node<T>? Head { get; private set; }

        public Node<T>? Tail { get; private set; }

        public void Prepend(T item)
        {
            var node = Node<T>.Create(item);

            this.Length++;

            if (this.Head == null && this.Tail == null)
            {
                this.Head = this.Tail = node;
                return;
            }

            node.Next = this.Head;
            this.Head.Prev = node;
            this.Head = node;
        }

        public void InsertAt(int index, T item)
        {
            if (index < 0 || index > this.Length)
            {
                throw new IndexOutOfRangeException();
            }
            else if (index == this.Length)
            {
                this.Append(item);
                return;
            }
            else if (index == 0)
            {
                this.Prepend(item);
                return;
            }

            var node = Node<T>.Create(item);
            this.Length++;

            var currentNode = this.Head;

            for (var i = 1; currentNode != null && i < index; i++)
            {
                currentNode = currentNode.Next;
            }

            var nextNode = currentNode.Next;
            currentNode.Next = node;
            node.Next = nextNode;
            nextNode.Prev = node;
            node.Prev = currentNode;
        }

        public void Append(T item)
        {
            this.Length++;

            var node = Node<T>.Create(item);

            if (this.Tail == null && this.Head == null)
            {
                this.Tail = this.Head = node;
                return;
            }

            node.Prev = this.Tail;
            this.Tail.Next = node;
            this.Tail = node;
        }

        public T? Remove(T item)
        {
            var currentNode = this.Head;

            for (var i = 0; currentNode != null && i < this.Length; i++)
            {
                if (currentNode.Value.Equals(item))
                {
                    break;
                }

                currentNode = currentNode.Next;
            }

            // Fail to delete anything, return.
            if (currentNode == null)
            {
                return default;
            }

            return this.RemoveNode(currentNode);
        }

        public T? Get(int index)
        {
            var node = this.GetAt(index);
            if (node == null)
            {
                return default;
            }

            return node.Value;
        }

        public T? RemoveAt(int index)
        {
            var currentNode = this.GetAt(index);

            if (currentNode == null)
            {
                return default;
            }

            return this.RemoveNode(currentNode);
        }

        private T? RemoveNode(Node<T> node)
        {
            this.Length--;

            if (this.Length == 0)
            {
                var value = this.Head.Value;
                this.Head = this.Tail = null;
                return value;
            }

            if (node.Prev != null)
            {
                node.Prev.Next = node.Next;
            }

            if (node.Next != null)
            {
                node.Next.Prev = node.Prev;
            }

            if (node == this.Head)
            {
                this.Head = node.Next;
            }

            if (node == this.Tail)
            {
                this.Tail = node.Prev;
            }

            node.Prev = node.Next = null;
            return node.Value;
        }

        private Node<T>? GetAt(int index)
        {
            var currentNode = this.Head;

            for (var i = 0; currentNode != null && i < index; i++)
            {
                currentNode = currentNode.Next;
            }

            return currentNode;
        }
    }
}
