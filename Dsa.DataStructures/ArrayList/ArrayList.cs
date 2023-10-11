namespace Dsa.DataStructures.ArrayList
{
    public sealed class ArrayList<T>
    {
        // Get: O(1) Push/Pop: O(1) Unshift: O(n)
        public int Capacity { get; set; } = 2;

        public T[] Values { get; private set; }

        public int Length { get; private set; } = 0;

        public ArrayList()
        {
            this.Values = new T[this.Capacity];
        }

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

        public T? Get(int index)
        {
            ref var value = ref this.Values[index];
            return value;
        }

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
