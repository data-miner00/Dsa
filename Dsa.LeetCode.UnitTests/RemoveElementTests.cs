namespace Dsa.LeetCode.UnitTests
{
    using Dsa.LeetCode.Practice;

    public sealed class RemoveElementTests
    {
        [Fact]
        public void Remove_ShouldShowCorrectArray()
        {
            int[] nums = [3, 2, 2, 3];

            var length = RemoveElement.Remove(nums, 3);

            Assert.Equal(2, length);
            Assert.Equal(2, nums[0]);
            Assert.Equal(2, nums[1]);
        }

        [Fact]
        public void Remove_LongerArray()
        {
            int[] nums = [0, 1, 2, 2, 3, 0, 4, 2];

            var length = RemoveElement.Remove(nums, 2);

            Assert.Equal(5, length);
        }

        [Fact]
        public void Remove_ArrayWithSingleFoundElement()
        {
            int[] nums = [1];

            var length = RemoveElement.Remove(nums, 1);

            Assert.Equal(0, length);
        }

        [Fact]
        public void Remove_ArrayWithTwoElement()
        {
            int[] nums = [4, 5];

            var length = RemoveElement.Remove(nums, 5);

            Assert.Equal(1, length);
        }

        [Fact]
        public void Remove_ArrayWithThreeTwos()
        {
            int[] nums = [2, 2, 2];

            var length = RemoveElement.Remove(nums, 2);

            Assert.Equal(0, length);
        }
    }
}
