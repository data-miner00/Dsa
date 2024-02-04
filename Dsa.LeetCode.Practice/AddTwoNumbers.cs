namespace Dsa.LeetCode.Practice
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/add-two-numbers/description/">Add Two Numbers</see>.
    /// </summary>
    public static class AddTwoNumbers
    {
        /// <summary>
        /// Add two linked list.
        /// <see href="https://leetcode.com/problems/add-two-numbers/submissions/1165589762/">My submission link</see>.
        /// </summary>
        /// <param name="l1">The first list.</param>
        /// <param name="l2">The second list.</param>
        /// <returns>The added list.</returns>
        public static ListNode Add(ListNode l1, ListNode l2)
        {
            var newNode = new ListNode((l1.val + l2.val) % 10);
            var x = (l1.val + l2.val) / 10;
            var current = newNode;

            while (l1.next != null && l2.next != null)
            {
                l1 = l1.next;
                l2 = l2.next;

                current.next = new ListNode((x + l1.val + l2.val) % 10);
                current = current.next;
                x = (x + l1.val + l2.val) / 10;
            }

            while (l1.next != null)
            {
                l1 = l1.next;

                current.next = new ListNode((x + l1.val) % 10);
                current = current.next;
                x = (x + l1.val) / 10;
            }

            while (l2.next != null)
            {
                l2 = l2.next;

                current.next = new ListNode((x + l2.val) % 10);
                current = current.next;
                x = (x + l2.val) / 10;
            }

            if (x > 0)
            {
                current.next = new ListNode(x);
            }

            return newNode;
        }
    }

    /// <summary>
    /// The node definition for <see cref="AddTwoNumbers"/>.
    /// </summary>
    public class ListNode
    {
        public int val;

        public ListNode? next;

        public ListNode(int val, ListNode? next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
