namespace Dsa.Algorithms.UnitTests;

using System.Collections.Generic;

public sealed class DiagonalTraversalTests
{
    [Fact]
    public void Traverse_SimpleMatrix_ExpectedResults()
    {
        List<List<int>> matrix = [
            [1, 2, 3],
            [4, 5, 6],
            [7, 8, 9],
        ];

        List<int> expected = [1, 2, 4, 7, 5, 3, 6, 8, 9];

        var result = DiagonalTraversal.Traverse(matrix);

        Assert.Equal(expected, result);
    }
}
