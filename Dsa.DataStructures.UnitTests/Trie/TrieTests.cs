namespace Dsa.DataStructures.UnitTests.Trie
{
    using Dsa.TestCore;

    [TestCaseOrderer("Dsa.TestCore.PriorityOrderer", "Dsa.TestCore")]
    public sealed class TrieTests : IClassFixture<TrieTestFixture>
    {
        private readonly TrieTestFixture fixture;

        public TrieTests(TrieTestFixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        [TestPriority(1)]
        public void Insert_ShouldInsertCorrectly()
        {
            var trie = this.fixture.Trie;

            trie.Insert("foo");
            trie.Insert("fool");
            trie.Insert("foolish");
            trie.Insert("bar");

            trie.Count.Should().Be(4);
        }

        [Theory]
        [TestPriority(2)]
        [InlineData("foo", true)]
        [InlineData("fool", true)]
        [InlineData("foolish", true)]
        [InlineData("foolishness", false)]
        [InlineData("barrington", false)]
        public void Search_ShouldReturnCorrectResult(string input, bool expectFound)
        {
            var trie = this.fixture.Trie;

            trie.Search(input).Should().Be(expectFound);
        }

        [Theory]
        [TestPriority(3)]
        [InlineData("f", true)]
        [InlineData("fo", true)]
        [InlineData("foo", true)]
        [InlineData("fool", true)]
        [InlineData("foolish", true)]
        [InlineData("b", true)]
        [InlineData("foolishness", false)]
        [InlineData("barrington", false)]
        [InlineData("c", false)]
        [InlineData("cat", false)]
        public void StartsWith_ShouldReturnCorrectResult(string prefix, bool expectExist)
        {
            var trie = this.fixture.Trie;

            trie.StartsWith(prefix).Should().Be(expectExist);
        }
    }
}
