namespace Dsa.DataStructures.UnitTests.Graph.AdjacencyList
{
    using System;
    using System.Collections.Generic;
    using Dsa.DataStructures.Graph.AdjacencyList;

    public sealed class DepthFirstSearchTests
    {
        [Theory]
        [MemberData(nameof(DepthFirstSearchTestData))]
        public void Search_ShouldSearchItemCorrectly(GraphEdge[][] graph, int source, int needle, int[] expectedPath)
        {
            var actual = DepthFirstSearch.Search(graph, source, needle);

            actual.Should().BeEquivalentTo(expectedPath);
        }

        public static IEnumerable<object[]> DepthFirstSearchTestData()
        {
            /*      (1) --- (4) ---- (5)
            //    /  |       |       /|
            // (0)   | ------|------- |
            //    \  |/      |        |
            //      (2) --- (3) ---- (6) */
            var graphList = new[]
            {
                new[]
                {
                    new GraphEdge(1, 3),
                    new GraphEdge(2, 1),
                },
                new[]
                {
                    new GraphEdge(0, 3),
                    new GraphEdge(2, 4),
                    new GraphEdge(4, 1),
                },
                new[]
                {
                    new GraphEdge(1, 4),
                    new GraphEdge(3, 7),
                    new GraphEdge(0, 1),
                },
                new[]
                {
                    new GraphEdge(2, 7),
                    new GraphEdge(4, 5),
                    new GraphEdge(6, 1),
                },
                new[]
                {
                    new GraphEdge(1, 1),
                    new GraphEdge(3, 5),
                    new GraphEdge(5, 2),
                },
                new[]
                {
                    new GraphEdge(6, 1),
                    new GraphEdge(4, 2),
                    new GraphEdge(2, 18),
                },
                new[]
                {
                    new GraphEdge(3, 1),
                    new GraphEdge(5, 2),
                },
            };

            /*     >(1)<--->(4) ---->(5)
            //    /          |       /|
            // (0)     ------|------- |
            //    \   v      v        v
            //     >(2) --> (3) <----(6) */
            var graphList2 = new[]
            {
                new[]
                {
                    new GraphEdge(1, 3),
                    new GraphEdge(2, 1),
                },
                new[]
                {
                    new GraphEdge(4, 1),
                },
                new[]
                {
                    new GraphEdge(3, 7),
                },
                Array.Empty<GraphEdge>(),
                new[]
                {
                    new GraphEdge(1, 1),
                    new GraphEdge(3, 5),
                    new GraphEdge(5, 2),
                },
                new[]
                {
                    new GraphEdge(2, 18),
                    new GraphEdge(6, 1),
                },
                new[]
                {
                    new GraphEdge(3, 1),
                },
            };

            yield return new object[]
            {
                graphList,
                0,
                6,
                new[] { 0, 1, 2, 3, 4, 5, 6 },
            };
            yield return new object[]
            {
                graphList2,
                0,
                6,
                new[] { 0, 1, 4, 5, 6 },
            };
            yield return new object[]
            {
                graphList2,
                6,
                0,
                Array.Empty<int>(),
            };
        }
    }
}
