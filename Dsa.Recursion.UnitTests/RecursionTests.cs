namespace Dsa.Recursion.UnitTests
{
    using Dsa.Recursion;

    public sealed class RecursionTests
    {
        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 6)]
        [InlineData(4, 24)]
        [InlineData(5, 120)]
        [InlineData(10, 3_628_800)]
        public void Normal_GivenNumber_ExpectCorrectFactorial(int number, int expected)
        {
            var actual = Factorial.Normal(number);
            actual.Should().Be(expected);
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 6)]
        [InlineData(4, 24)]
        [InlineData(5, 120)]
        [InlineData(10, 3_628_800)]
        public void TailRecursive_GivenNumber_ExpectCorrectFactorial(int number, int expected)
        {
            var actual = Factorial.TailRecursive(number);
            actual.Should().Be(expected);
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 6)]
        [InlineData(4, 24)]
        [InlineData(5, 120)]
        [InlineData(10, 3_628_800)]
        public void Recursive_GivenNumber_ExpectCorrectFactorial(int number, int expected)
        {
            var actual = Factorial.Recursive(number);
            actual.Should().Be(expected);
        }
    }
}
