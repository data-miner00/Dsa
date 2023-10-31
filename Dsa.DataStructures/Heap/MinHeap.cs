namespace Dsa.DataStructures.Heap
{
    using System;

    /// <summary>
    /// The basic implementation of the minimum heap.
    /// MinHeap usages: Priority queue.
    /// </summary>
    /// <typeparam name="T">The type of the data.</typeparam>
    public sealed class MinHeap<T>
        where T : IComparable<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MinHeap{T}"/> class.
        /// </summary>
        /// <param name="maxLength">The maximum length of the heap allocated.</param>
        public MinHeap(int maxLength)
        {
            this.Data = new T[maxLength];
        }

        /// <summary>
        /// Gets the length of the heap.
        /// </summary>
        public int Length { get; private set; }

        /// <summary>
        /// Gets or sets the underlying array that stores the data.
        /// </summary>
        private T[] Data { get; set; }

        /// <summary>
        /// Insert a value into the heap. Time complexity: O(log n).
        /// </summary>
        /// <param name="value">The value to insert.</param>
        public void Insert(T value)
        {
            this.Data[this.Length] = value;
            this.HeapifyUpRecurse(this.Length);
            this.Length++;
        }

        /// <summary>
        /// Delete the root of the heap (smallest element).
        /// </summary>
        /// <returns>The removed item.</returns>
        public T? Delete()
        {
            if (this.Length == 0)
            {
                return default;
            }

            var @out = this.Data[0];
            this.Length--;

            if (this.Length == 0)
            {
                this.Data[0] = default;
                return @out;
            }

            this.Data[0] = this.Data[this.Length];
            this.HeapifyDownRecurse(0);
            return @out;
        }

        private static int ParentIndex(int index)
        {
            return (index - 1) / 2;
        }

        private static int LeftChildIndex(int index)
        {
            return (2 * index) + 1;
        }

        private static int RightChildIndex(int index)
        {
            return (2 * index) + 2;
        }

        private void HeapifyUpRecurse(int index)
        {
            if (index == 0)
            {
                return;
            }

            var parent = ParentIndex(index);
            var parentValue = this.Data[parent];
            var currentValue = this.Data[index];

            if (parentValue.CompareTo(currentValue) > 0)
            {
                this.Data[index] = parentValue;
                this.Data[parent] = currentValue;
                this.HeapifyUpRecurse(parent);
            }
        }

        private void HeapifyDownRecurse(int index)
        {
            var leftIndex = LeftChildIndex(index);
            var rightIndex = RightChildIndex(index);

            if (index >= this.Length || leftIndex >= this.Length)
            {
                return;
            }

            var leftValue = this.Data[leftIndex];
            var rightValue = this.Data[rightIndex];
            var currentValue = this.Data[index];

            if (leftValue.CompareTo(rightValue) > 0 && currentValue.CompareTo(rightValue) > 0)
            {
                this.Data[index] = rightValue;
                this.Data[rightIndex] = currentValue;
                this.HeapifyDownRecurse(rightIndex);
            }
            else if (rightValue.CompareTo(leftValue) > 0 && currentValue.CompareTo(leftValue) > 0)
            {
                this.Data[index] = leftValue;
                this.Data[leftIndex] = currentValue;
                this.HeapifyDownRecurse(leftIndex);
            }
        }
    }
}
