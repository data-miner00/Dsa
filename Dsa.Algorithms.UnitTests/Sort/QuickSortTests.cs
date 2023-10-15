namespace Dsa.Algorithms.UnitTests.Sort
{
    using Dsa.Algorithms.Sort;

    public sealed class QuickSortTests
    {
        [Fact]
        public void QuickSort_ShouldSortTheArrayCorrectly()
        {
            var numbers = new[] { 6, 2, 7, 56, 3, 7, 9 };
            var expected = new[] { 2, 3, 6, 7, 7, 9, 56 };

            QuickSort.Sort(numbers);

            numbers.Should().BeEquivalentTo(expected);
        }
    }
}
