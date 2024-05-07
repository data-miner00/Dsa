namespace Dsa.Recursion.UnitTests;

using Dsa.Recursion;

public class MemoizedFibonacciTests
{
    private readonly MemoizedFibonacci fibonacci;

    public MemoizedFibonacciTests()
    {
        this.fibonacci = new();
    }

    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, 1)]
    [InlineData(2, 1)]
    [InlineData(3, 2)]
    [InlineData(8, 21)]
    [InlineData(9, 34)]
    public void Get_Fibonacci_ExpectedResults(int position, int expected)
    {
        var result = this.fibonacci.Get(position);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void GenerateSequence_20Elements_ExpectedResults()
    {
        List<int> expected = [0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181];

        var result = this.fibonacci.GenerateSequence(20);

        var expectedCacheHits = 33;

        Assert.Equal(expected, result);
        Assert.Equal(expectedCacheHits, this.fibonacci.CacheHits);
    }
}
