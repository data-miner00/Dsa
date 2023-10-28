namespace Dsa.DataStructures.BinaryTree
{
    /// <summary>
    /// Operations on a binary tree.
    /// </summary>
    public static partial class BinaryTree
    {
        /// <summary>
        /// Pre-order DFS through a binary tree.
        /// </summary>
        /// <typeparam name="T">The type of the item.</typeparam>
        /// <param name="head">The head of the binary tree.</param>
        /// <returns>The result of the traversal.</returns>
        public static IEnumerable<T> PreOrderTraversal<T>(BinaryNode<T> head)
        {
            return WalkPreOrder(head, new Queue<T>()).AsEnumerable();
        }

        /// <summary>
        /// In-order DFS through a binary tree.
        /// </summary>
        /// <typeparam name="T">The type of the item.</typeparam>
        /// <param name="head">The head of the binary tree.</param>
        /// <returns>The result of the traversal.</returns>
        public static IEnumerable<T> InOrderTraversal<T>(BinaryNode<T> head)
        {

            return WalkInOrder(head, new Queue<T>()).AsEnumerable();
        }

        /// <summary>
        /// Post-order DFS through a binary tree.
        /// </summary>
        /// <typeparam name="T">The type of the item.</typeparam>
        /// <param name="head">The head of the binary tree.</param>
        /// <returns>The result of the traversal.</returns>
        public static IEnumerable<T> PostOrderTraversal<T>(BinaryNode<T> head)
        {
            return WalkPostOrder(head, new Queue<T>()).AsEnumerable();
        }

        private static Queue<T> WalkPreOrder<T>(BinaryNode<T>? current, Queue<T> path)
        {
            if (current == null)
            {
                return path;
            }

            // Pre
            path.Enqueue(current.Value);

            // Recurese
            WalkPreOrder(current.Left, path);
            WalkPreOrder(current.Right, path);

            // Post
            return path;
        }

        private static Queue<T> WalkInOrder<T>(BinaryNode<T>? current, Queue<T> path)
        {
            if (current == null)
            {
                return path;
            }

            // Pre

            // Recurese
            WalkInOrder(current.Left, path);
            path.Enqueue(current.Value);
            WalkInOrder(current.Right, path);

            // Post
            return path;
        }

        private static Queue<T> WalkPostOrder<T>(BinaryNode<T>? current, Queue<T> path)
        {
            if (current == null)
            {
                return path;
            }

            // Pre

            // Recurese
            WalkPostOrder(current.Left, path);
            WalkPostOrder(current.Right, path);

            // Post
            path.Enqueue(current.Value);
            return path;
        }
    }
}
