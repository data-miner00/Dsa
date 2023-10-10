namespace Dsa.Algorithms.UnitTests
{
    using Dsa.Algorithms;

    public sealed class TwoCrystalBallsTests
    {
        [Theory]
        [InlineData(new[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false }, -1)]
        [InlineData(new[] { false, false, false, false, false, false, false, true, true, true, true, true, true, true }, 7)]
        [InlineData(new[] { false, false, false, false, false, false, false, false, false, true, true, true, true, true, true, true, true }, 9)]
        [InlineData(new[] { true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true }, 0)]
        public void FindIndex_ShouldFindTheFirstIndex(bool[] breaks, int expectedIndex)
        {
            var actualIndex = TwoCrystalBalls.FindIndex(breaks);

            actualIndex.Should().Be(expectedIndex);
        }
    }
}