namespace Dsa.DataStructures.UnitTests.Heap
{
    using Dsa.DataStructures.Heap;

    public sealed class MinHeapFixture
    {
        public MinHeap<int> MinHeap { get; set; } = new MinHeap<int>(20);
    }
}
