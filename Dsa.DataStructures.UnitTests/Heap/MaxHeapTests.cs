namespace Dsa.DataStructures.UnitTests.Heap
{
    [TestCaseOrderer("Dsa.DataStructures.UnitTests.PriorityOrderer", "Dsa.DataStructures.UnitTests")]
    public sealed class MaxHeapTests : IClassFixture<MaxHeapFixture>
    {
        private readonly MaxHeapFixture fixture;

        public MaxHeapTests(MaxHeapFixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact, TestPriority(1)]
        public void MaxHeap_Insert_ShouldInsertCorrectly()
        {
            var heap = this.fixture.MaxHeap;

            heap.Length.Should().Be(0);

            heap.Insert(5);
            heap.Insert(3);
            heap.Insert(69);
            heap.Insert(420);
            heap.Insert(4);
            heap.Insert(1);
            heap.Insert(8);
            heap.Insert(7);

            heap.Length.Should().Be(8);
        }

        [Fact]
        [TestPriority(2)]
        public void MaxHeap_Poll_ShouldDeleteCorrectly()
        {
            var heap = this.fixture.MaxHeap;

            heap.Length.Should().Be(8);

            heap.Poll().Should().Be(420);
            heap.Poll().Should().Be(69);
            heap.Poll().Should().Be(8);
            heap.Poll().Should().Be(7);

            heap.Length.Should().Be(4);

            heap.Poll().Should().Be(5);
            heap.Poll().Should().Be(4);
            heap.Poll().Should().Be(3);
            heap.Poll().Should().Be(1);

            heap.Length.Should().Be(0);
        }
    }
}
