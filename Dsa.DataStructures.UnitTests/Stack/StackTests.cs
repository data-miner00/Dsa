namespace Dsa.DataStructures.UnitTests.Stack
{
    using Dsa.DataStructures.Stack;

    public sealed class StackTests
    {
        [Fact]
        public void Constructor_ShouldCreate()
        {
            var stack = new Stack<int>();

            stack.Push(10);

            stack.Length.Should().Be(1);

            stack.Peek().Should().Be(10);
        }
    }
}
