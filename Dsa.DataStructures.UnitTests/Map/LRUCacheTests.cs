namespace Dsa.DataStructures.UnitTests.Map
{
    using Dsa.DataStructures.Map;
    using Dsa.TestCore;

    [TestCaseOrderer("Dsa.TestCore.PriorityOrderer", "Dsa.TestCore")]
    public sealed class LRUCacheTests : IClassFixture<LRUCacheFixture>
    {
        private readonly LRUCacheFixture fixture;

        public LRUCacheTests(LRUCacheFixture fixture)
        {
            this.fixture = fixture;
        }

        private LRUCache<string, object> Lru => this.fixture.LRU;

        [Fact]
        [TestPriority(1)]
        public void Get_ReturnsNullWhenNotExist()
        {
            var actual = this.Lru.Get("foo");

            actual.Should().Be(null);
        }

        [Fact]
        [TestPriority(2)]
        public void Get_ReturnsValueWhenExist()
        {
            this.Lru.Update("foo", 69);
            this.Lru.Update("bar", 420);
            this.Lru.Update("baz", 1337);

            var actual = this.Lru.Get("foo");

            actual.Should().Be(69);

            actual = this.Lru.Get("bar");

            actual.Should().Be(420);

            actual = this.Lru.Get("baz");

            actual.Should().Be(1337);
        }

        [Fact]
        [TestPriority(3)]
        public void Get_ReturnsNullWhenExceededCapacity()
        {
            this.Lru.Update("ball", 666);

            var actual = this.Lru.Get("foo");

            actual.Should().Be(null);
        }
    }
}
