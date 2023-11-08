namespace Dsa.Algorithms.UnitTests.Greedy
{
    using Dsa.Algorithms.Greedy;
    using Dsa.DataStructures.Graph.AdjacencyList;

    public sealed class DijkstraAlgorithmTests
    {
        private readonly GraphEdge[][] graph;

        public DijkstraAlgorithmTests()
        {
            /*      (1) --- (4) ---- (5)
            //    /  |       |       /|
            // (0)   | ------|------- |
            //    \  |/      |        |
            //      (2) --- (3) ---- (6) */
            this.graph = new[]
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
        }

        [Fact]
        public void ShortestPath_ShouldReturnShortestPath()
        {
            var actual = DijkstraAlgorithm.ShortestPath(this.graph, 0, 6);

            actual.Should().BeEquivalentTo(new[] { 0, 1, 4, 5, 6 });
        }
    }
}
