namespace Dsa.LeetCode.UnitTests;

using Dsa.LeetCode.Practice;

public sealed class SearchInsertPositionTests
{
    [Theory]
    [InlineData(new int[] { 1, 3, 5, 6 }, 5, 2)]
    [InlineData(new int[] { 1, 3, 5, 6 }, 2, 1)]
    [InlineData(new int[] { 1, 3, 5, 6 }, 7, 4)]
    [InlineData(new int[] { 1, 3, 4, 7, 8, 11, 15 }, 2, 1)]
    public void Search_ShouldReturnCorrectIndex(int[] nums, int target, int expectedIndex)
    {
        var index = SearchInsertPosition.Search(nums, target);

        Assert.Equal(expectedIndex, index);
    }
}
