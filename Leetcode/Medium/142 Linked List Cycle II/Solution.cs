using Leetcode.LeetCodeTypes;

namespace Leetcode.Medium._142_Linked_List_Cycle_II;

public class Solution {
    public ListNode? DetectCycle(ListNode? head) {
        ListNode? slow = head;
        ListNode? fast = head;

        do {
            fast = fast?.next?.next;
            slow = slow?.next;
        } while (fast != null && fast != slow);

        //no cycle
        if (fast == null)
            return null;

        //there is a cycle
        slow = head;
        while (fast != slow) {
            fast = fast.next;
            slow = slow.next;
        }
        
        return fast;
    }
}