namespace Dsa.DataStructures.UnitTests.Queue
{
    using Dsa.DataStructures.Queue;
    using FluentAssertions;

    public sealed class QueueTests
    {
        [Fact]
        public void Enqueue_ShouldAddItemsCorrectly()
        {
            var queue = new Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            queue.Peek().Should().Be(1);
            queue.Length.Should().Be(3);
            queue.Tail.Value.Should().Be(3);
        }

        [Fact]
        public void Dequeue_ShouldRemoveItemCorrectly()
        {
            var queue = new Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            queue.Dequeue().Should().Be(1);
            queue.Peek().Should().Be(2);
            queue.Tail.Value.Should().Be(4);
            queue.Length.Should().Be(3);
        }
    }
}
