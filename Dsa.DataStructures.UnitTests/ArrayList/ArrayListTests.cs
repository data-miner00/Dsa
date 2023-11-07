namespace Dsa.DataStructures.UnitTests.ArrayList
{
    using Dsa.DataStructures.ArrayList;

    public sealed class ArrayListTests
    {
        [Fact]
        public void Prepend_ItemShouldInsertedInFront()
        {
            var list = new ArrayList<int>();

            list.Prepend(1);
            list.Capacity.Should().Be(2);

            list.Prepend(2);
            list.Prepend(3);

            list.Get(0).Should().Be(3);
            list.Get(1).Should().Be(2);
            list.Get(2).Should().Be(1);
            list.Length.Should().Be(3);
            list.Capacity.Should().Be(4);
        }

        [Fact]
        public void Append_ItemShouldInsertedAtBack()
        {
            var list = new ArrayList<int>();

            list.Append(1);
            list.Append(2);
            list.Capacity.Should().Be(2);

            list.Append(3);

            list.Get(0).Should().Be(1);
            list.Get(1).Should().Be(2);
            list.Get(2).Should().Be(3);
            list.Length.Should().Be(3);
            list.Capacity.Should().Be(4);
        }

        [Fact]
        public void InsertAt_ItemShouldInsertAtCorrectPosition()
        {
            var list = new ArrayList<int>();

            list.Append(1);
            list.Prepend(5);
            list.Append(23);
            list.InsertAt(2, 999);

            list.Get(2).Should().Be(999);
        }

        [Fact]
        public void InsertAt_ExpansionShouldDoneCorrectly()
        {
            var list = new ArrayList<int>();

            list.Append(1);
            list.Capacity.Should().Be(2);
            list.InsertAt(1, 54);

            list.Get(1).Should().Be(54);
            list.Length.Should().Be(2);
            list.Capacity.Should().Be(4);
        }

        [Fact]
        public void Remove_FoundItem_ItemRemoved()
        {
            var list = new ArrayList<int>();

            list.Append(1);
            list.Append(2);
            list.Append(3);
            list.Append(4);
            list.Append(5);
            list.Length.Should().Be(5);

            list.Remove(4);
            list.Length.Should().Be(4);

            list.Get(3).Should().Be(5);
        }

        [Fact]
        public void RemoveAt_FoundItem_ItemRemoved()
        {
            var list = new ArrayList<int>();

            list.Append(1);
            list.Append(2);
            list.Append(3);
            list.Append(4);
            list.Append(5);
            list.Length.Should().Be(5);

            list.RemoveAt(2);
            list.RemoveAt(2);

            list.Length.Should().Be(3);
            list.Get(2).Should().Be(5);
        }
    }
}
