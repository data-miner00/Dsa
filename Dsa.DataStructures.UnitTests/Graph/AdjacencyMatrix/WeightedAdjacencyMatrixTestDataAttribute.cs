namespace Dsa.DataStructures.UnitTests.Graph.AdjacencyMatrix
{
    using System.Collections.Generic;
    using System.Reflection;
    using Xunit.Sdk;

    /// <summary>
    /// Test data for graph represented by weighted adjacency matrix.
    /// </summary>
    public sealed class WeightedAdjacencyMatrixTestDataAttribute : DataAttribute
    {
        /// <inheritdoc/>
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            yield return new object[]
            {
                /*     >(1)<--->(4) ---->(5)
                //    /          |       /|
                // (0)     ------|------- |
                //    \   v      v        v
                //     >(2) --> (3) <----(6) */
                new int[][]
                {
                    new int[] { 0, 3, 1,  0, 0, 0, 0 }, // 0
                    new int[] { 0, 0, 0,  0, 1, 0, 0 },
                    new int[] { 0, 0, 7,  0, 0, 0, 0 },
                    new int[] { 0, 0, 0,  0, 0, 0, 0 },
                    new int[] { 0, 1, 0,  5, 0, 2, 0 },
                    new int[] { 0, 0, 18, 0, 0, 0, 1 },
                    new int[] { 0, 0, 0,  1, 0, 0, 1 },
                },
                0,
                6,
                new int[] { 0, 1, 4, 5, 6 },
            };

            yield return new object[]
            {
                /*     >(1)<--->(4) ---->(5)
                //    /          |       /|
                // (0)     ------|------- |
                //    \   v      v        v
                //     >(2) --> (3) <----(6) */
                new int[][]
                {
                    new int[] { 0, 3, 1,  0, 0, 0, 0 }, // 0
                    new int[] { 0, 0, 0,  0, 1, 0, 0 },
                    new int[] { 0, 0, 7,  0, 0, 0, 0 },
                    new int[] { 0, 0, 0,  0, 0, 0, 0 },
                    new int[] { 0, 1, 0,  5, 0, 2, 0 },
                    new int[] { 0, 0, 18, 0, 0, 0, 1 },
                    new int[] { 0, 0, 0,  1, 0, 0, 1 },
                },
                6,
                0,
                Array.Empty<int>(),
            };
        }
    }
}
