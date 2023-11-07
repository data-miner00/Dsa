namespace Dsa.Algorithms
{
    /// <summary>
    /// Binary search implementation with two pointers. Time complexity: O(n).
    /// The list must be sorted in a non-decreasing order.
    /// </summary>
    public static class BinarySearch
    {
        /// <summary>
        /// Search wheather the stack contains the needle.
        /// </summary>
        /// <typeparam name="T">Any type of object.</typeparam>
        /// <param name="haystack">The original array.</param>
        /// <param name="needle">The item to be searched.</param>
        /// <returns>A boolean indicating found or not.</returns>
        public static bool IsContains<T>(this T[] haystack, T needle)
            where T : IComparable<T>
        {
            var lo = 0;
            var hi = haystack.Length;

            do
            {
                var midpoint = Convert.ToInt32(Math.Floor((double)lo + ((hi - lo) / 2)));
                var currentElem = haystack[midpoint];

                if (currentElem.Equals(needle))
                {
                    return true;
                }
                else if (currentElem.CompareTo(needle) > 0) // CurrentElement > needle
                {
                    hi = midpoint;
                }
                else if (currentElem.CompareTo(needle) < 0) // CurrentElement < needle
                {
                    lo = midpoint + 1;
                }
            }
            while (lo < hi);

            return false;
        }
    }
}
