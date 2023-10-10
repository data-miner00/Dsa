namespace Dsa.Algorithms
{
    /// <summary>
    /// Binary search implementation with two pointers. Time complexity: O(n).
    /// The list must be sorted in a non-decreasing order.
    /// </summary>
    public static class BinarySearch
    {
        public static bool IsContains<T>(this T[] haystack, T needle)
            where T : IComparable<T>
        {
            var lo = 0;
            var hi = haystack.Length;

            do
            {
                var midpoint = Convert.ToInt32(Math.Floor((double)lo + (hi - lo) / 2));
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
            } while (lo < hi);

            return false;
        }
    }
}
