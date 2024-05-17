namespace Dsa.DataStructures.UnitTests.DoublyLinkedList;

using Dsa.DataStructures.DoublyLinkedList;

public sealed class SortedListTests
{
    [Fact]
    public void Insert_WithoutOrder_OrderedOutput()
    {
        var sortedList = new SortedList<int>();

        sortedList.Insert(5);
        sortedList.Insert(1);
        sortedList.Insert(3);
        sortedList.Insert(4);
        sortedList.Insert(2);
        sortedList.Insert(6);

        var ascending = (int[])Array.CreateInstance(typeof(int), sortedList.Length);
        var descending = (int[])Array.CreateInstance(typeof(int), sortedList.Length);
        Node<int> front = sortedList.Head;
        Node<int> back = sortedList.Tail;

        for (int i = 0; i < sortedList.Length; i++)
        {
            ascending[i] = front.Value;
            descending[i] = back.Value;
            front = front.Next;
            back = back.Prev;
        }

        int[] expectedAscending = [1, 2, 3, 4, 5, 6];
        int[] expectedDescending = [6, 5, 4, 3, 2, 1];

        Assert.Equal(expectedAscending, ascending);
        Assert.Equal(expectedDescending, descending);
    }
}
