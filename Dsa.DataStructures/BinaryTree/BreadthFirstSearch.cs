namespace Dsa.DataStructures.BinaryTree
{
    using System.Collections.Generic;

    /// <summary>
    /// Operations on a binary tree.
    /// </summary>
    public static partial class BinaryTree
    {
        // Breadth-first search
        // BFS does NOT preserves structure.
        public static bool BreadthFirstSearch<T>(BinaryNode<T> head, T needle)
        {
            var queue = new Queue<BinaryNode<T>>();
            queue.Enqueue(head);

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();

                if (current == null)
                {
                    continue;
                }

                if (current.Value.Equals(needle))
                {
                    return true;
                }

                if (current.Left != null)
                {
                    queue.Enqueue(current.Left);
                }

                if (current.Right != null)
                {
                    queue.Enqueue(current.Right);
                }
            }

            return false;
        }
    }
}
