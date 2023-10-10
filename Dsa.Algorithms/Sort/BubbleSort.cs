namespace Dsa.Algorithms.Sort
{
    /// <summary>
    /// The bubble sort implementation. Time complexity: O(n^2).
    /// </summary>
    public static class BubbleSort
    {
        public static void Sort<T>(T[] list)
            where T : IComparable<T>
        {
            for (var i = 0; i < list.Length; i++)
            {
                for (var j = 0; j < list.Length - i - 1; j++)
                {
                    if (list[j].CompareTo(list[j + 1]) > 0)
                    {
                        (list[j + 1], list[j]) = (list[j], list[j + 1]);
                    }
                }
            }
        }
    }
}
