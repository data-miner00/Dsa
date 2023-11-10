namespace Dsa.DataStructures.UnitTests.Map
{
    using Dsa.DataStructures.Map;

    public sealed class LRUCacheFixture
    {
        public LRUCache<string, object> LRU { get; set; } = new(3);
    }
}
