namespace Dsa.Algorithms.UnitTests.Sort
{
    using Dsa.Algorithms.Sort;

    public sealed class BubbleSortTests
    {
        [Fact]
        public void BubbleSort_SortArrayInPlaceCorrectly()
        {
            var array = new[] { 5, 2, 6, 3, 6, 7, 2, 1, 6, 483, 43, 12, 9 };
            var expectedArray = new[] { 1, 2, 2, 3, 5, 6, 6, 6, 7, 9, 12, 43, 483 };

            array.Length.Should().Be(expectedArray.Length);

            BubbleSort.Sort(array);

            array.Should().BeEquivalentTo(expectedArray);
        }
    }
}
