namespace Dsa.DataStructures.DoublyLinkedList;

using System;

public sealed class SortedList<T>
    where T : IComparable<T>
{
    public int Length { get; private set; } = 0;

    public Node<T>? Head { get; private set; }

    public Node<T>? Tail { get; private set; }

    public void Insert(T item)
    {
        var node = new Node<T>
        {
            Value = item,
        };

        if (this.Head is null)
        {
            this.Head = this.Tail = node;
        }
        else if (this.Head is not null && this.Head == this.Tail)
        {
            if (item.CompareTo(this.Head.Value) > 0)
            {
                this.Tail = node;
                this.Head.Next = this.Tail;
                this.Tail.Prev = this.Head;
            }
            else
            {
                this.Head = node;
                this.Tail.Prev = this.Head;
                this.Head.Next = this.Tail;
            }
        }
        else
        {
            var currentNode = this.Head;

            for (var i = 0; currentNode != null; i++)
            {
                if (item.CompareTo(currentNode.Value) < 0)
                {
                    var prev = currentNode.Prev;
                    prev.Next = node;
                    node.Prev = prev;
                    node.Next = currentNode;
                    currentNode.Prev = node;
                    break;
                }

                currentNode = currentNode.Next;
            }

            if (currentNode is null)
            {
                var last = this.Tail;
                last.Next = node;
                node.Prev = last;
                this.Tail = node;
            }
        }

        this.Length++;
    }
}
