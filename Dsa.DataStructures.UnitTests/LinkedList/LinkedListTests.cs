namespace Dsa.DataStructures.UnitTests.LinkedList
{
    using Dsa.DataStructures.LinkedList;
    using FluentAssertions;
    using Xunit.Sdk;

    public sealed class LinkedListTests
    {
        [Fact]
        public void AppendItem_ShouldInsertWithCorrectItem()
        {
            var list = new LinkedList<int>();
            list.Append(1);
            list.Append(2);
            list.Append(5);

            list.Get(0).Should().Be(1);
            list.Get(1).Should().Be(2);
            list.Get(2).Should().Be(5);
        }

        [Fact]
        public void PrependItem_ShouldInsertWithCorrectItem()
        {
            var list = new LinkedList<int>();
            list.Prepend(1);
            list.Prepend(52);
            list.Prepend(23);

            list.Get(0).Should().Be(23);
            list.Get(1).Should().Be(52);
            list.Get(2).Should().Be(1);
        }
    }
}
