namespace Dsa.DataStructures.Graph.AdjacencyMatrix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public sealed class BreadthFirstSearch
    {
        public static int[] Search(int[][] matrix, int source, int needle)
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
