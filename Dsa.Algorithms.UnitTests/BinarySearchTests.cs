namespace Dsa.Algorithms.UnitTests
{
    using Dsa.Algorithms;
    using Xunit.Abstractions;

    public sealed class BinarySearchTests : IDisposable
    {
        private readonly ITestOutputHelper output;

        public BinarySearchTests(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void BinarySearch_ShouldFoundCorrespondingItem()
        {
            var ints = new[] { 1, 2, 3, 999, 53, 478, 120, 330, 742, 1000, 3092, 32 };

            Array.Sort(ints);
            this.output.WriteLine(ints.ToString());

            ints.IsContains(458).Should().BeFalse();
            ints.IsContains(1).Should().BeTrue();
            ints.IsContains(32).Should().BeTrue();
            ints.IsContains(1000).Should().BeTrue();
            ints.IsContains(478).Should().BeTrue();
        }

        public void Dispose()
        {
            this.output.WriteLine("Disposing");
        }
    }
}
