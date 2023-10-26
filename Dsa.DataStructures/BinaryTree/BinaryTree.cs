namespace Dsa.DataStructures.BinaryTree
{
    public sealed class BinaryNode<T>
    {
        public T? Value { get; set; }

        public BinaryNode<T>? Left { get; set; }

        public BinaryNode<T>? Right { get;set; }
    }

    /// <summary>
    /// Operations on a binary tree.
    /// </summary>
    public static partial class BinaryTree
    {
        // Depth-first search
        // DFS preserves structure.
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

        public static IEnumerable<T> PreOrderTraversal<T>(BinaryNode<T> head)
        {
            return WalkPreOrder(head, new Queue<T>()).AsEnumerable();
        }

        public static IEnumerable<T> InOrderTraversal<T>(BinaryNode<T> head)
        {

            return WalkInOrder(head, new Queue<T>()).AsEnumerable();
        }

        public static IEnumerable<T> PostOrderTraversal<T>(BinaryNode<T> head)
        {
            return WalkPostOrder(head, new Queue<T>()).AsEnumerable();
        }
    }
}
