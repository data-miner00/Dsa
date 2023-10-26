namespace Dsa.DataStructures.BinaryTree
{
    public static partial class BinaryTree
    {
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
