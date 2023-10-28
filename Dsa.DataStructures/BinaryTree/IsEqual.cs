namespace Dsa.DataStructures.BinaryTree
{
    /// <summary>
    /// Operations on a binary tree.
    /// </summary>
    public static partial class BinaryTree
    {
        /// <summary>
        /// Check whether two given binary tree is equivalent in value and structure.
        /// </summary>
        /// <typeparam name="T">The generic type of the items.</typeparam>
        /// <param name="self">The original tree.</param>
        /// <param name="other">The other tree to compare against.</param>
        /// <returns>The Boolean value indicating the trees are equal or not.</returns>
        public static bool IsEqual<T>(this BinaryNode<T>? self, BinaryNode<T>? other)
        {
            if (self == null && other == null)
            {
                return true;
            }

            if (self == null || other == null)
            {
                return false;
            }

            if (!self.Value.Equals(other.Value))
            {
                return false;
            }

            return IsEqual(self.Left, other.Left) && IsEqual(self.Right, other.Right);
        }
    }
}
