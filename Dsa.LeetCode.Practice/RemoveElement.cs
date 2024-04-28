namespace Dsa.LeetCode.Practice;

/// <summary>
/// <see href="https://leetcode.com/problems/remove-element/description/">Remove element</see>.
/// </summary>
public static class RemoveElement
{
    /// <summary>
    /// Using two pointer, front and back.
    /// <see cref="https://leetcode.com/problems/remove-element/submissions/1243703616/">My submission link</see>.
    /// </summary>
    /// <param name="nums">The original array.</param>
    /// <param name="val">The value to be removed.</param>
    /// <returns>The length of array without <paramref name="val"/>.</returns>
    public static int Remove(int[] nums, int val)
    {
        int front = 0, back = nums.Length - 1;
        while (front < back + 1)
        {
            if (nums[front] == val)
            {
                while (nums[back--] == val)
                {
                    if (back < 0)
                    {
                        return 0;
                    }
                }

                if (back < front)
                {
                    break;
                }

                (nums[front], nums[back + 1]) = (nums[back + 1], nums[front]);
            }

            front++;
        }

        return front;
    }
}
