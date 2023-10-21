namespace Dsa.DataStructures.UnitTests.BinaryTree
{
    using Dsa.DataStructures.BinaryTree;
    using Xunit.Abstractions;

    public sealed class BinaryTreeTests : IClassFixture<BinaryTreeFixture>
    {
        private readonly BinaryTreeFixture fixture;
        private readonly ITestOutputHelper output;

        public BinaryTreeTests(BinaryTreeFixture fixture, ITestOutputHelper output)
        {
            this.fixture = fixture;
            this.output = output;
        }

        [Fact]
        public void PreOrderTraversal_ShouldTraverseInCorrectOrder()
        {
            var expected = new[] { 20, 10, 5, 7, 15, 50, 30, 29, 45, 100 };

            var actual = BinaryTree.PreOrderTraversal(this.fixture.Tree1);

            actual.ToArray().Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void InOrderTraversal_ShouldTraverseInCorrectOrder()
        {
            var expected = new[] { 5, 7, 10, 15, 20, 29, 30, 45, 50, 100 };

            var actual = BinaryTree.InOrderTraversal(this.fixture.Tree1);

            actual.ToArray().Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void PostOrderTraversal_ShouldTraverseInCorrectOrder()
        {
            var expected = new[] { 7, 5, 15, 10, 29, 45, 30, 100, 50, 20 };

            var actual = BinaryTree.PostOrderTraversal(this.fixture.Tree1);

            actual.ToArray().Should().BeEquivalentTo(expected);
        }
    }
}
