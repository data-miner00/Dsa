namespace Dsa.DataStructures.ArrayList
{
    /// <summary>
    /// The implementation of array list.
    /// </summary>
    /// <typeparam name="T">Type of the item.</typeparam>
    public sealed class ArrayList<T>
    {
        // Get: O(1) Push/Pop: O(1) Unshift: O(n)

        /// <summary>
        /// Initializes a new instance of the <see cref="ArrayList{T}"/> class.
        /// </summary>
        public ArrayList()
        {
            this.Values = new T[this.Capacity];
        }

        /// <summary>
        /// Gets the initial capacity of the array list. Defaulted to 2.
        /// </summary>
        public int Capacity { get; private set; } = 2;

        /// <summary>
        /// Gets the internal array representation of the data.
        /// </summary>
        public T[] Values { get; private set; }

        /// <summary>
        /// Gets the current count of items stored.
        /// </summary>
        public int Length { get; private set; } = 0;

        /// <summary>
        /// Add the item to the front of the list.
        /// </summary>
        /// <param name="item">The item to be added.</param>
        public void Prepend(T item)
        {
            if (this.Length == this.Capacity - 1)
            {
                this.Capacity *= 2;
                var original = (T[])this.Values.Clone();
                this.Values = new T[this.Capacity];

                this.Values[0] = item;
                for (var i = 0; i < original.Length; i++)
                {
                    this.Values[i + 1] = original[i];
                }

                this.Length++;

                return;
            }

            for (var i = this.Length; i > 0; i--)
            {
                this.Values[i] = this.Values[i - 1];
            }

            this.Values[0] = item;

            this.Length++;
        }

        /// <summary>
        /// Insert an element at the given index.
        /// </summary>
        /// <param name="index">The index of the item to be inserted.</param>
        /// <param name="item">The item to be inserted.</param>
        public void InsertAt(int index, T item)
        {
            if (this.Length == this.Capacity - 1)
            {
                this.Capacity *= 2;
                var original = this.Values;
                this.Values = new T[this.Capacity];

                var i = 0;
                for (; i < index; i++)
                {
                    this.Values[i] = original[i];
                }

                this.Values[index] = item; // index

                for (; i < original.Length; i++)
                {
                    this.Values[i + 1] = original[i];
                }

                this.Length++;

                return;
            }

            for (var i = this.Length; i > index; i--)
            {
                this.Values[i] = this.Values[i - 1];
            }

            this.Values[index] = item;

            this.Length++;
        }

        /// <summary>
        /// Insert an item at the end of the list.
        /// </summary>
        /// <param name="item">The item to be inserted.</param>
        public void Append(T item)
        {
            if (this.Length == this.Capacity)
            {
                this.Capacity *= 2;
                var original = this.Values;
                this.Values = new T[this.Capacity];

                var i = 0;
                for (; i < original.Length; i++)
                {
                    this.Values[i] = original[i];
                }

                this.Values[i] = item;

                this.Length++;
                return;
            }

            this.Values[this.Length] = item;
            this.Length++;
        }

        /// <summary>
        /// Remove an item that matches the value.
        /// </summary>
        /// <param name="item">The item to be removed.</param>
        /// <returns>The removed item. Null if item not found.</returns>
        public T? Remove(T item)
        {
            var isFoundItem = false;
            var i = 0;
            for (; i < this.Length; i++)
            {
                isFoundItem = this.Values[i].Equals(item);

                if (isFoundItem)
                {
                    break;
                }
            }

            if (isFoundItem)
            {
                for (; i < this.Length; i++)
                {
                    this.Values[i - 1] = this.Values[i];
                }

                this.Length--;
                return item;
            }

            return default;
        }

        /// <summary>
        /// Retrieves an item at the given index.
        /// </summary>
        /// <param name="index">The index of item to be retrieved.</param>
        /// <returns>The retrieved item.</returns>
        public T? Get(int index)
        {
            ref var value = ref this.Values[index];
            return value;
        }

        /// <summary>
        /// Remove an item at the given index.
        /// </summary>
        /// <param name="index">The index of item to be removed.</param>
        /// <returns>The item removed. Null if not found.</returns>
        public T? RemoveAt(int index)
        {
            var removeValue = this.Values[index];

            for (var i = index; i < this.Length; i++)
            {
                this.Values[i] = this.Values[i + 1];
            }

            if (removeValue != null)
            {
                this.Length--;
            }

            return removeValue;
        }
    }
}
