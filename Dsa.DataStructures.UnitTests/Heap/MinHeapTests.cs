namespace Dsa.DataStructures.UnitTests.Heap
{
    public sealed class MinHeapTests : IClassFixture<MinHeapFixture>
    {
        private readonly MinHeapFixture fixture;

        public MinHeapTests(MinHeapFixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public void MinHeap_Insert_ShouldInsertCorrectly()
        {
            var heap = this.fixture.MinHeap;

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
        public void MinHeap_Delete_ShouldDeleteCorrectly()
        {
            var heap = this.fixture.MinHeap;

            heap.Length.Should().Be(8);

            heap.Delete().Should().Be(1);
            heap.Delete().Should().Be(3);
            heap.Delete().Should().Be(4);
            heap.Delete().Should().Be(5);

            heap.Length.Should().Be(4);

            heap.Delete().Should().Be(7);
            heap.Delete().Should().Be(8);
            heap.Delete().Should().Be(69);
            heap.Delete().Should().Be(420);

            heap.Length.Should().Be(0);
        }
    }
}
