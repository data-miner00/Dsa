namespace Dsa.DataStructures.UnitTests.Heap
{
    using Dsa.DataStructures.Heap;

    public sealed class MaxHeapFixture
    {
        public MaxHeap<int> MaxHeap { get; set; } = new MaxHeap<int>(20);
    }
}
