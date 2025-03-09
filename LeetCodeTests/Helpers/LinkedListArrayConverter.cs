using LeetCode.LeetCodeTypes;

namespace LeetCodeTests.Helpers;

#nullable disable
public static class LinkedListArrayConverter {
    public static List<int> ToList(this ListNode linkedList) {
        var list = new List<int>();
        var current = linkedList;
        
        while (current is not null) {
            list.Add(current.val);
            current = current.next;
        }

        return list;
    }
    public static ListNode ToListNode(this int[] nums) {
        var head = new ListNode();
        var current = head;

        for (var i = 0; i < nums.Length; i++)
            current = current.next = new ListNode(nums[i]);

        current.next = null;

        return head.next;
    }
}
