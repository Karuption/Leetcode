using Leetcode.LeetCodeTypes;

namespace Leetcode.Medium._21_Merge_Two_Sorted_Lists; 

#nullable disable
public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode head = new();       
        var current = head;
        
        while(list1 is not null && list2 is not null) {
            if(list1.val<list2.val)
                list1 = (current.next = list1).next;
            else
                list2 = (current.next = list2).next;
            
            current = current.next;
        }

        current.next = list1 ?? list2;

        return head.next;
    }
}