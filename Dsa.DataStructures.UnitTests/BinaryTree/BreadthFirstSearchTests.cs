namespace Dsa.DataStructures.UnitTests.BinaryTree
{
    using Dsa.DataStructures.BinaryTree;

    public sealed class BreadthFirstSearchTests : IClassFixture<BinaryTreeFixture>
    {
        private readonly BinaryTreeFixture fixture;

        public BreadthFirstSearchTests(BinaryTreeFixture fixture)
        {
            this.fixture = fixture;
        }

        [Theory]
        [InlineData(45, true)]
        [InlineData(7, true)]
        [InlineData(59, false)]
        public void BreadthFirstSearch_ShouldReturnResultCorrectly(int elem, bool expected)
        {
            var actual = BinaryTree.BreadthFirstSearch(this.fixture.Tree1, elem);
            actual.Should().Be(expected);
        }
    }
}
