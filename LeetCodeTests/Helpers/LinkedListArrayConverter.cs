using Leetcode.LeetCodeTypes;

namespace LeetCodeTests.Helpers;

public static class LinkedListArrayConverter {
    public static ListNode ToListNode(this int[] nums) {
        var head = new ListNode();
        var current = head;

        for (var i = 0; i < nums.Length; i++) {
            current.val = nums[i];
            current.next = new ListNode();
            current = current.next;
        }

        current.next = null;

        return head;
    }
}
