using LeetCode.LeetCodeTypes;
using LeetCode.Medium._142_Linked_List_Cycle_II;
using LeetCodeTests.Helpers;

namespace LeetCodeTests.Medium._142_Linked_List_Cycle_II;

public class BaseCases {
    [Theory]
    [InlineData(new[] { 3, 2, 0, -4 }, 1)]
    [InlineData(new[] { 1, 2 }, 0)]
    [InlineData(new[] { 1 }, -1)]
    public void BaseCase(int[] linkedList, int expectedPosition) {
        var head = linkedList.ToListNode();
        ListNode expected = null;

        if (expectedPosition >= 0) {
            var current = head;
            var i = 0;
            //seek to the expected position
            while (i++ < expectedPosition)
                current = current.next;

            //set the instance to the expected position
            expected = current;

            //find the end of the linked list
            while (current.next != null)
                current = current.next;

            //create the cycle
            current.next = expected;
        }

        var solution = new Solution();

        var actual = solution.DetectCycle(head);

        Assert.Equal(expected?.val, actual?.val);
    }
}