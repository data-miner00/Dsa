namespace Dsa.LeetCode.Solution
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// <see href="https://leetcode.com/problems/zigzag-conversion/description/">Zigzag Conversion</see>.
    /// </summary>
    public static class Zigzag
    {
        /// <summary>
        /// Solution by <see href="https://leetcode.com/4o3F/">4o3F</see>.
        /// </summary>
        /// <param name="s">The string to be converted.</param>
        /// <param name="rows">The number of rows the zigzag pattern requires.</param>
        /// <returns>The converted string.</returns>
        public static string Convert1(string s, int rows)
        {
            if (rows <= 1)
            {
                return s;
            }

            StringBuilder[] list = Enumerable
                .Range(0, rows)
                .Select(_ => new StringBuilder())
                .ToArray();

            var currentLine = 0;
            var reachedEdge = true;

            for (var i = 0; i < s.Length; i++)
            {
                if (currentLine == 0 || currentLine == rows - 1)
                {
                    reachedEdge = !reachedEdge;
                }

                list[currentLine].Append(s[i]);

                if (!reachedEdge)
                {
                    currentLine++;
                }
                else
                {
                    currentLine--;
                }
            }

            var resultBuilder = new StringBuilder();
            for (int i = 0; i < rows; i++)
            {
                resultBuilder.Append(list[i]);
            }

            return resultBuilder.ToString();
        }
    }
}
