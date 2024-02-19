namespace Dsa.LeetCode.Practice
{
    using System;

    /// <summary>
    /// <see href="https://leetcode.com/problems/power-of-two/description/">Power of Two</see>.
    /// </summary>
    public static class PowerOfTwo
    {
        /// <summary>
        /// Determine whether a number is power of 2.
        /// <see href="https://leetcode.com/problems/power-of-two/submissions/1179770790">My submission link</see>.
        /// </summary>
        /// <param name="n">The number.</param>
        /// <returns>Whether the number is power of 2.</returns>
        public static bool Is(int n)
        {
            return (Math.Log10(n) / Math.Log10(2)) % 1 == 0;
        }
    }
}
