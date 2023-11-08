namespace Dsa.DataStructures.Graph.AdjacencyList
{
    using System;
    using System.Collections.Generic;

    public static class DepthFirstSearch
    {
        public static int[] Search(GraphEdge[][] graph, int source, int needle)
        {
            var seen = new bool[graph.Length];
            Array.Fill(seen, false);
            Stack<int> path = new();

            Walk(graph, source, needle, seen, path);

            return path.ToArray();
        }

        private static bool Walk(GraphEdge[][] graph, int current, int needle, bool[] seen, Stack<int> path)
        {
            if (seen[current])
            {
                return false;
            }

            seen[current] = true;

            // pre
            path.Push(current);

            if (current == needle)
            {
                return true;
            }

            // recurse
            var list = graph[current];
            for (var i = 0; i < list.Length; ++i)
            {
                var edge = list[i];

                if (Walk(graph, edge.To, needle, seen, path))
                {
                    return true;
                }
            }

            // post
            path.Pop();

            return false;
        }
    }
}
