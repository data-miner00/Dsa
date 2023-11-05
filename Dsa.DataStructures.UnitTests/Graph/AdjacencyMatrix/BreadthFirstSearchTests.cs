namespace Dsa.DataStructures.UnitTests.Graph.AdjacencyMatrix
{
    using Dsa.DataStructures.Graph.AdjacencyMatrix;

    public sealed class BreadthFirstSearchTests
    {
        [Theory]
        [WeightedAdjacencyMatrixTestData]
        public void Search_ShouldReturnTraversalPath(int[][] matrix, int source, int needle, int[] expectedPath)
        {
            var result = BreadthFirstSearch.Search(matrix, source, needle);
            result.Should().BeEquivalentTo(expectedPath);
        }
    }
}
