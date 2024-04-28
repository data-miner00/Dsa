namespace Dsa.LeetCode.Practice;

/// <summary>
/// <see href="https://leetcode.com/problems/search-insert-position/description/">Search Insert Position</see>.
/// </summary>
public static class SearchInsertPosition
{
    /// <summary>
    /// Search the index with log(n) if exist, if not the proposed index.
    /// <see href="https://leetcode.com/problems/search-insert-position/submissions/1243759870/">My submission link</see>.
    /// </summary>
    /// <param name="nums">The sorted, distinct number array.</param>
    /// <param name="target">The target to be find.</param>
    /// <returns>The actual or proposed index of the <paramref name="target"/>.</returns>
    public static int Search(int[] nums, int target)
    {
        int low = 0, high = nums.Length - 1;

        while (low <= high)
        {
            var mid = (low + high) / 2;

            if (nums[mid] == target)
            {
                return mid;
            }
            else if (nums[mid] > target)
            {
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }

        return low;
    }
}
