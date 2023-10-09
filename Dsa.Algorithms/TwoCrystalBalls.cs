namespace Dsa.Algorithms
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Given an array of booleans, try to find the index of the first occurrence of desired item
    /// optimally. The array given is sorted.
    /// </summary>
    public static class TwoCrystalBalls
    {
        /// <summary>
        /// Searches for the first index of the occurrence by leaping instead of linearly from
        /// start to found. Time complexity: O(sqrt(n)).
        /// </summary>
        /// <param name="breaks">The array of sorted booleans.</param>
        /// <returns>The found index of the first occurrence. <code>-1</code> if not found.</returns>
        public static int FindIndex(IEnumerable<bool> breaks)
        {
            var jumpAmount = Convert.ToInt32(Math.Floor(Math.Sqrt(breaks.Count())));

            var index = jumpAmount;

            for (; index < breaks.Count(); index += jumpAmount)
            {
                if (breaks.ElementAt(new Index(index)))
                {
                    break;
                }
            }

            index -= jumpAmount;

            for (var jndex = 0; jndex < jumpAmount && index < breaks.Count(); ++index, ++jndex)
            {
                if (breaks.ElementAt(new Index(index)))
                {
                    return index;
                }
            }

            return -1;
        }
    }
}