namespace Dsa.DataStructures.BinaryTree
{
    /// <summary>
    /// The binary node wrapper class.
    /// </summary>
    /// <typeparam name="T">The type of the item.</typeparam>
    public sealed class BinaryNode<T>
    {
        /// <summary>
        /// Gets or sets the value of the item.
        /// </summary>
        public T? Value { get; set; }

        /// <summary>
        /// Gets or sets the left node.
        /// </summary>
        public BinaryNode<T>? Left { get; set; }

        /// <summary>
        /// Gets or sets the right node.
        /// </summary>
        public BinaryNode<T>? Right { get;set; }
    }
}
