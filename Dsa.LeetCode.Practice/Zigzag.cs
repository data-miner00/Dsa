namespace Dsa.LeetCode.Practice
{
    using System.Text;

    /// <summary>
    /// <see href="https://leetcode.com/problems/zigzag-conversion/description/">Zigzag Conversion</see>.
    /// </summary>
    public static class Zigzag
    {
        /// <summary>
        /// Convert to a linearly read, zigzag string.
        /// <see href="https://leetcode.com/problems/zigzag-conversion/submissions/1160546719/">My submission link</see>.
        /// </summary>
        /// <param name="s">The string to be converted.</param>
        /// <param name="rows">The number of rows the zigzag pattern requires.</param>
        /// <returns>The converted string.</returns>
        public static string Convert(string s, int rows)
        {
            var sb = new StringBuilder();
            var len = s.Length;
            var gap = (rows * 2) - 2;
            if (gap == 0)
            {
                gap++;
            }

            var bars = 1 + ((len - rows) / gap);
            var rem = (len - rows) % gap;

            if (rem > 0)
            {
                bars++;
            }

            for (var i = 0; i < rows; i++)
            {
                for (var j = 0; j < bars; j++)
                {
                    if ((i == 0 || i == rows - 1) && (gap * j) + i < len)
                    {
                        sb.Append(s[(gap * j) + i]);
                    }

                    if (j > 0 && i > 0 && i < rows - 1 && (gap * j) - i < len)
                    {
                        sb.Append(s[(gap * j) - i]);
                    }

                    if (i > 0 && i < rows - 1 && (gap * j) + i < len)
                    {
                        sb.Append(s[(gap * j) + i]);
                    }
                }
            }

            return sb.ToString();
        }
    }
}
