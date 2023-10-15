namespace Dsa.Algorithms.Sort
{
    /// <summary>
    /// The implementation of QuickSort.
    /// </summary>
    public static class QuickSort
    {
        private static void Qs(int[] arr, int lo, int hi)
        {
            if (lo >= hi)
            {
                return;
            }

            var pivotIdx = Partition(arr, lo, hi);

            Qs(arr, lo, pivotIdx - 1);
            Qs(arr, pivotIdx + 1, hi);
        }

        private static int Partition(int[] arr, int lo, int hi)
        {
            var pivot = arr[hi];
            var idx = lo - 1;

            for (var i = lo; i < hi; ++i)
            {
                if (arr[i] <= pivot)
                {
                    idx++;
                    var tmp = arr[i];
                    arr[i] = arr[idx];
                    arr[idx] = tmp;
                }
            }

            idx++;

            arr[hi] = arr[idx];
            arr[idx] = pivot;

            return idx;
        }
        
        public static void Sort(int[] numbers)
        {
            Qs(numbers, 0, numbers.Length - 1);
        }
    }
}
