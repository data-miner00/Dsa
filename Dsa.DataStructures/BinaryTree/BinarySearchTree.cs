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

        /// <summary>
        /// Deletes the node and returns the root reference.
        /// Implementation excerpted from <see href="https://www.geeksforgeeks.org/deletion-in-binary-search-tree/">Geeks</see>.
        /// Updated at <see href="https://www.youtube.com/watch?v=LFzAoJJt92M">NeetCodeIO</see>.
        /// </summary>
        /// <typeparam name="T">Type that is comparable.</typeparam>
        /// <param name="node">The head of BST.</param>
        /// <param name="value">The value to find and delete.</param>
        /// <returns>The root reference.</returns>
        public static BinaryNode<T>? Delete<T>(BinaryNode<T>? node, T value)
            where T : IComparable<T>
        {
            // 1. If the node is null, do nothing and return.
            if (node == null)
            {
                return node;
            }

            // 2. Traverse left if target is lesser than current,
            // traverse right if target is larger than current.
            if (value.CompareTo(node.Value) < 0)
            {
                node.Left = Delete(node.Left, value);
                return node;
            }
            else if (value.CompareTo(node.Value) > 0)
            {
                node.Right = Delete(node.Right, value);
                return node;
            }

            // 3. If one of the children is empty
            if (node.Left is null)
            {
                return node.Right; // if right is empty, it is fine too
            }
            else if (node.Right is null)
            {
                return node.Left;
            }
            else
            {
                // 4. If both children exists, go to the leftmost children of the current right
                // child
                var curr = node.Right;

                while (curr.Left is not null)
                {
                    curr = curr.Left;
                }

                node.Value = curr.Value;
                node.Right = Delete(node.Right, node.Value);

                return node;
            }
        }

        /// <summary>
        /// Delete the node if found and return the deleted node.
        /// </summary>
        /// <typeparam name="T">Type that is comparable.</typeparam>
        /// <param name="node">The head of BST.</param>
        /// <param name="value">The value to find and delete.</param>
        /// <returns>The deleted node.</returns>
        public static BinaryNode<T>? DeleteInplace<T>(BinaryNode<T>? node, T value)
            where T : IComparable<T>
        {
            return DeleteInplace(node, value, null);
        }

        public static BinaryNode<T>? DeleteInplace<T>(BinaryNode<T>? node, T value, BinaryNode<T> parent)
            where T : IComparable<T>
        {
            if (node is null)
            {
                return node;
            }

            if (node.Value.CompareTo(value) > 0)
            {
                return DeleteInplace(node.Left, value, node);
            }
            else if (node.Value.CompareTo(value) < 0)
            {
                return DeleteInplace(node.Right, value, node);
            }

            var immediateParent = node;
            var pointer = node.Right;

            while (pointer.Left is not null)
            {
                immediateParent = pointer;
                pointer = pointer.Left;
            }

            var leftNodeToBeRelocated = immediateParent.Left;

            if (immediateParent == node) // if left is null and right got elem
            {
                immediateParent.Left = pointer.Right;
            }

            leftNodeToBeRelocated.Left = node.Left;
            leftNodeToBeRelocated.Right = node.Right;
            parent.Right = leftNodeToBeRelocated;

            return node;
        }
    }
}
