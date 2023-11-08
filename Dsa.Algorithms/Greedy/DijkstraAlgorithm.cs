namespace Dsa.Algorithms.Greedy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Dsa.DataStructures.Graph.AdjacencyList;

    public static class DijkstraAlgorithm
    {
        public static int[] ShortestPath(GraphEdge[][] graph, int source, int sink)
        {
            var seen = new bool[graph.Length];
            Array.Fill(seen, false);

            var prev = new int[graph.Length];
            Array.Fill(prev, -1);

            var dists = new int[graph.Length];
            Array.Fill(dists, int.MaxValue);
            dists[source] = 0;

            while (HasUnvisited(seen, dists))
            {
                var current = GetLowestUnvisited(seen, dists);

                seen[current] = true;

                var adjs = graph[current];
                for (var i = 0; i < adjs.Length; ++i)
                {
                    var edge = adjs[i];
                    if (seen[edge.To])
                    {
                        continue;
                    }

                    var dist = dists[current] + edge.Weight;
                    if (dist < dists[edge.To])
                    {
                        dists[edge.To] = dist;
                        prev[edge.To] = current;
                    }
                }
            }

            var output = new Queue<int>();
            var curr = sink;

            while (prev[curr] != -1)
            {
                output.Enqueue(curr);
                curr = prev[curr];
            }

            output.Enqueue(source);

            return output.Reverse().ToArray();
        }

        private static bool HasUnvisited(bool[] seen, int[] dists)
        {
            var zipped = seen.Zip(dists);

            return zipped.Any((zip) => !zip.First && zip.Second < int.MaxValue);
        }

        private static int GetLowestUnvisited(bool[] seen, int[] dists)
        {
            var index = -1;
            var lowestDistance = int.MaxValue;

            for (var i = 0; i < seen.Length; i++)
            {
                if (seen[i])
                {
                    continue;
                }

                if (lowestDistance > dists[i])
                {
                    lowestDistance = dists[i];
                    index = i;
                }
            }

            return index;
        }
    }
}
