namespace Dsa.DataStructures.Map
{
    using System.Collections.Generic;

    public sealed class LRUCache<K, V>
    {
        public LRUCache(int capacity)
        {
            this.Capacity = capacity;
        }

        public int Capacity { get; set; }

        public int Length { get; private set; } = 0;

        private Node<V>? Head { get; set; }

        private Node<V>? Tail { get; set; }

        private Dictionary<K, Node<V>> Lookup { get; set; } = new();

        private Dictionary<Node<V>, K> ReverseLookup { get; set; } = new();

        public void Update(K key, V value)
        {
            // does it exist?
            // if it doesn't we need to insert
            this.Lookup.TryGetValue(key, out Node<V>? node);
            if (node == null)
            {
                node = new(value);
                this.Length++;
                this.Prepend(node);
                this.TrimCache(); // check capacity and evict if over
                this.Lookup[key] = node;
                this.ReverseLookup[node] = key;
            }
            else
            {
                // if it does, we need to update to the front of list and update the value
                this.Detach(node);
                this.Prepend(node);

                node.Value = value;
            }
        }

        public V? Get(K key)
        {
            // check the cache for existence
            this.Lookup.TryGetValue(key, out var node);

            if (node == null)
            {
                return default;
            }

            // update the value we found and move it to the front
            this.Detach(node);
            this.Prepend(node);

            // return out the value found or null if not exist
            return node.Value;
        }

        private void Detach(Node<V> node)
        {
            if (node.Previous != null)
            {
                node.Previous.Next = node.Next;
            }

            if (node.Next != null)
            {
                node.Next.Previous = node.Previous;
            }

            /* if (this.Length == 1)
            {
                this.Tail = this.Head = null;
            }*/

            if (this.Head == node)
            {
                this.Head = this.Head.Next;
            }

            if (this.Tail == node)
            {
                this.Tail = this.Tail.Previous;
            }

            node.Next = node.Previous = null;
        }

        private void Prepend(Node<V> node)
        {
            if (this.Head == null)
            {
                this.Head = this.Tail = node;
                return;
            }

            node.Next = this.Head;
            this.Head.Previous = node;
            this.Head = node;
        }

        private void TrimCache()
        {
            if (this.Length <= this.Capacity)
            {
                return;
            }

            var tail = this.Tail;
            this.Detach(this.Tail);

            var key = this.ReverseLookup[tail]!;

            this.Lookup.Remove(key);
            this.ReverseLookup.Remove(tail);
            this.Length--;
        }
    }
}
