namespace Dsa.DataStructures.BinaryTree
{
    using System;

    /// <summary>
    /// Collection of methods for Binary Search Tree (BST).
    /// </summary>
    public static class BinarySearchTree
    {
        /// <summary>
        /// Find an element in a Binary Search Tree. Complexity: between O(log n) to O(n)
        /// </summary>
        /// <typeparam name="T">Type that is comparable.</typeparam>
        /// <param name="node">The head of the BST.</param>
        /// <param name="value">The value to find.</param>
        /// <returns>The flag that indicates whether the element was found.</returns>
        public static bool Find<T>(BinaryNode<T>? node, T value)
            where T : IComparable<T>
        {
            if (node == null)
            {
                return false;
            }

            if (node.Value.Equals(value))
            {
                return true;
            }

            if (node.Value.CompareTo(value) < 0)
            {
                return Find(node.Right, value);
            }

            return Find(node.Left, value);
        }

        /// <summary>
        /// Inserts an element into a Binary Search Tree.
        /// </summary>
        /// <typeparam name="T">Type that is comparable.</typeparam>
        /// <param name="node">The head of BST.</param>
        /// <param name="value">The value to insert.</param>
        public static void Insert<T>(BinaryNode<T> node, T value)
            where T : IComparable<T>
        {
            if (value.CompareTo(node.Value) <= 0 && node.Left != null)
            {
                Insert(node.Left, value);
                return;
            }

            if (value.CompareTo(node.Value) <= 0 && node.Left == null)
            {
                node.Left = new BinaryNode<T> { Value = value };
                return;
            }

            if (value.CompareTo(node.Value) > 0 && node.Right != null)
            {
                Insert(node.Right, value);
                return;
            }

            node.Right = new BinaryNode<T> { Value = value };
        }

        // TODO: Implement deletion
        public static void Delete<T>(BinaryNode<T>? node, T value)
            where T : IComparable<T>
        {
            if (node == null)
            {
                return;
            }

            if (node.Value.Equals(value) && node.Right != null)
            {
                
                
            }
            else if (node.Left != null && node.Left.Left == null && node.Left.Right == null && node.Left.Value.Equals(value))
            {
                node.Left = null;
            }
            else if (node.Right != null && node.Right.Left == null && node.Right.Right == null && node.Right.Value.Equals(value))
            {
                node.Right = null;
            }
            
        }
    }
}
