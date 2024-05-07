namespace Dsa.Algorithms;

using System.Collections.Generic;

public static class DiagonalTraversal
{
    public static List<int> Traverse(List<List<int>> matrix)
    {
        var result = new List<int>();
        var goingUp = true;
        int i = 0, j = 0;

        for (var k = 0; k < matrix[0].Count * matrix.Count;)
        {
            if (goingUp)
            {
                for (; i >= 0 && j < matrix[0].Count; i--, j++)
                {
                    result.Add(matrix[i][j]);
                    k++;
                }

                if (i <= 0)
                {
                    i++;
                }

                if (j >= matrix[0].Count)
                {
                    i++;
                    j--;
                }
            }
            else
            {
                for (; i < matrix.Count && j >= 0; j--, i++)
                {
                    result.Add(matrix[i][j]);
                    k++;
                }

                if (j <= 0)
                {
                    j++;
                }

                if (i >= matrix.Count)
                {
                    i--;
                    j++;
                }
            }

            goingUp = !goingUp;
        }

        return result;
    }
}
