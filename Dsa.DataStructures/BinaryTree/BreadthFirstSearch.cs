namespace Dsa.DataStructures.BinaryTree
{
    using System.Collections.Generic;

    /// <summary>
    /// Operations on a binary tree.
    /// </summary>
    public static partial class BinaryTree
    {
        /// <summary>
        /// Breadth-first search through a binary tree. BFS does NOT preserve the tree structure.
        /// </summary>
        /// <typeparam name="T">The type of the item.</typeparam>
        /// <param name="head">The head of the tree.</param>
        /// <param name="needle">The value to find.</param>
        /// <returns>Boolean indicating whether the element was found or not.</returns>
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
