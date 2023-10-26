namespace Dsa.DataStructures.UnitTests.BinaryTree
{
    using Dsa.DataStructures.BinaryTree;

    public sealed class IsEqualTests : IClassFixture<BinaryTreeFixture>
    {
        private readonly BinaryTreeFixture fixture;

        public IsEqualTests(BinaryTreeFixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public void IsEqual_EqualTrees_ShouldReturnTrue()
        {
            var actual = this.fixture.Tree1.IsEqual(this.fixture.Tree1);
            actual.Should().BeTrue();
        }

        [Fact]
        public void IsEqual_DifferentTrees_ShouldReturnFalse()
        {
            var actual = this.fixture.Tree1.IsEqual(this.fixture.Tree2);
            actual.Should().BeFalse();
        }
    }
}
