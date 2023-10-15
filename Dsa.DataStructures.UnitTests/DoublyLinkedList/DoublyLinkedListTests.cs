namespace Dsa.DataStructures.UnitTests.DoublyLinkedList
{
    using Dsa.DataStructures.DoublyLinkedList;

    public sealed class DoublyLinkedListTests
    {
        [Fact]
        public void Prepend_ItemsInsertedAtCorrectPosition()
        {
            var list = new DoublyLinkedList<int>();

            list.Prepend(1);
            list.Prepend(2);
            list.Prepend(3);

            list.Length.Should().Be(3);

            list.Get(0).Should().Be(3);
            list.Get(1).Should().Be(2);
            list.Get(2).Should().Be(1);

            list.Head.Value.Should().Be(3);
            list.Tail.Value.Should().Be(1);
        }

        [Fact]
        public void Append_ItemsInsertedAtCorrectPosition()
        {
            var list = new DoublyLinkedList<int>();

            list.Append(1);
            list.Append(2);
            list.Append(3);

            list.Length.Should().Be(3);

            list.Get(0).Should().Be(1);
            list.Get(1).Should().Be(2);
            list.Get(2).Should().Be(3);

            list.Head.Value.Should().Be(1);
            list.Tail.Value.Should().Be(3);
        }

        [Fact]
        public void InsertAt_ItemsInsertedAtCorrectPosition()
        {
            var list = new DoublyLinkedList<int>();

            list.Append(1);
            list.Append(2);
            list.Append(3);
            list.Append(4);
            list.Append(5);

            list.Length.Should().Be(5);

            list.InsertAt(3, 100);

            list.Length.Should().Be(6);

            list.Get(0).Should().Be(1);
            list.Get(1).Should().Be(2);
            list.Get(2).Should().Be(3);
            list.Get(3).Should().Be(100);
            list.Get(4).Should().Be(4);
            list.Get(5).Should().Be(5);

            list.Head.Value.Should().Be(1);
            list.Tail.Value.Should().Be(5);
        }

        [Fact]
        public void Remove_ItemsFoundRemovedCorrectly()
        {
            var list = new DoublyLinkedList<int>();

            list.Append(1);
            list.Append(2);
            list.Append(3);
            list.Append(4);
            list.Append(5);

            list.Length.Should().Be(5);

            var expected = list.Remove(3);
            expected.Should().Be(3);

            list.Length.Should().Be(4);

            list.Get(0).Should().Be(1);
            list.Get(1).Should().Be(2);
            list.Get(2).Should().Be(4);
            list.Get(3).Should().Be(5);

            list.Head.Value.Should().Be(1);
            list.Tail.Value.Should().Be(5);
        }

        [Fact]
        public void RemoveAt_ValidIndexItemRemoved()
        {
            var list = new DoublyLinkedList<int>();

            list.Append(1);
            list.Append(2);
            list.Append(3);
            list.Append(4);
            list.Append(5);

            list.Length.Should().Be(5);

            var expected = list.RemoveAt(2);
            expected.Should().Be(3);

            list.Length.Should().Be(4);

            list.Get(0).Should().Be(1);
            list.Get(1).Should().Be(2);
            list.Get(2).Should().Be(4);
            list.Get(3).Should().Be(5);

            list.Head.Value.Should().Be(1);
            list.Tail.Value.Should().Be(5);
        }
    }
}
