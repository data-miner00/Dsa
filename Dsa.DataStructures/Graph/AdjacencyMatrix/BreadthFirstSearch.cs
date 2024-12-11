namespace Dsa.DataStructures.Graph.AdjacencyMatrix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Searching through a graph with BFS.
    /// </summary>
    public static class BreadthFirstSearch
    {
        /// <summary>
        /// Search through the graph with BFS strategy.
        /// </summary>
        /// <param name="matrix">The adjacency matrix that represents the graph.</param>
        /// <param name="source">The source of the node to begin the search.</param>
        /// <param name="needle">The target item to be searched.</param>
        /// <returns>An array of ints representing the paths went through. Empty if item not found.</returns>
#pragma warning disable S2368 // Public methods should not have multidimensional array parameters
        public static int[] Search(int[][] matrix, int source, int needle)
#pragma warning restore S2368 // Public methods should not have multidimensional array parameters
        {
            var seen = new bool[matrix.Length];
            var prev = new int[matrix.Length];
            Array.Fill(prev, -1);

            seen[source] = true;
            var queue = new Queue<int>();
            queue.Enqueue(source);

            do
            {
                var current = queue.Dequeue();

                if (current == needle)
                {
                    break;
                }

                var adjs = matrix[current];
                for (var i = 0; i < matrix.Length; i++)
                {
                    if (adjs[i] == 0)
                    {
                        continue;
                    }

                    if (seen[i])
                    {
                        continue;
                    }

                    seen[i] = true;
                    prev[i] = current;
                    queue.Enqueue(i);
                }
            }
            while (queue.Count > 0);

            // build it backwards
            var current2 = needle;
            var output = new Queue<int>();

            while (prev[current2] != -1)
            {
                output.Enqueue(current2);
                current2 = prev[current2];
            }

            if (output.Count > 0)
            {
                output.Enqueue(source);
                return output.Reverse().ToArray();
            }

            return Array.Empty<int>();
        }
    }
}
