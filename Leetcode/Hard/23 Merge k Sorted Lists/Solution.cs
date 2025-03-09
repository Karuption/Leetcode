using LeetCode.LeetCodeTypes;

namespace LeetCode.Hard._23_Merge_k_Sorted_Lists; 

//Simple Initial solution, creates new nodes
// public class Solution {
//     public ListNode MergeKLists(ListNode[] lists) {
//         ListNode[] current = new ListNode[lists.Length];
//         ListNode outputHead = new ListNode();
//
//         for (int i = 0; i < current.Length; i++)
//             current[i] = lists[i];
//
//         int min  = int.MaxValue;
//         int index = -1;
//         ListNode output = outputHead;
//
//         while (true) {
//             for (int i = 0; i < current.Length; i++) {
//                 if (current[i] != null && current[i].val < min) {
//                     min = current[i].val;
//                     index = i;
//                 }
//             }
//
//             if (index != -1) {
//                 output.next = new ListNode(current[index].val);
//                 output = output.next;
//                 
//                 current[index] = current[index].next;
//                 index = -1;
//                 min = int.MaxValue;
//             } else {
//                 break;
//             }
//         }
//
//
//         return outputHead?.next;
//     }
// }

//Version 2, destructive to the input array, but less allocations
// public class Solution {
//     public ListNode MergeKLists(ListNode[] lists) {
//         ListNode[] current = new ListNode[lists.Length];
//         ListNode outputHead = new ListNode();
//
//         for (int i = 0; i < current.Length; i++)
//             current[i] = lists[i];
//
//         int min  = int.MaxValue;
//         int index = -1;
//         ListNode output = outputHead;
//
//         while (true) {
//             for (int i = 0; i < current.Length; i++) {
//                 if (current[i] != null && current[i].val < min) {
//                     min = current[i].val;
//                     index = i;
//                 }
//             }
//
//             if (index != -1) {
//                 output.next = current[index];
//                 output = output.next;
//                 current[index] = current[index].next;
//                 output.next = null;
//                 
//                 index = -1;
//                 min = int.MaxValue;
//             } else {
//                 break;
//             }
//         }
//
//
//         return outputHead.next;
//     }
// }

// //Merge them all together one at a time
// public class Solution {
//     public ListNode MergeKLists(ListNode[] lists) {
//         if (lists == null || lists.Length == 0)
//             return null;
//         
//         ListNode outputHead = lists[0];
//
//         for (int i = 1; i < lists.Length; i++)
//             outputHead = Merge2Lists(outputHead, lists[i]);
//
//         return outputHead;
//     }
//
//     private ListNode Merge2Lists(ListNode list1, ListNode list2) {
//         ListNode head = new ListNode();
//         ListNode current = head;
//
//         while (list1 != null && list2 != null) {
//             if (list1.val < list2.val) {
//                 current.next = list1;
//                 list1 = list1.next;
//             } else {
//                 current.next = list2;
//                 list2 = list2.next;
//             }
//
//             current = current.next;
//             current.next = null;
//         }
//
//         current.next = list1 ?? list2;
//
//         return head.next;
//     }
// }

//Binary Merge with Spans
public class Solution {
    public ListNode? MergeKLists(Span<ListNode?> lists) {
        if (lists.IsEmpty || lists.Length == 0)
            return null;

        if (lists.Length == 1)
            return lists[0];

        int mid = lists.Length / 2;
        ListNode? right = null;
        
        var left = MergeKLists(lists.Slice(0, mid));
        
        if(mid<lists.Length-1)
            right = MergeKLists(lists.Slice(mid+1)); 

        return Merge2Lists(Merge2Lists(left,right), lists[mid]);
    }

    private ListNode? Merge2Lists(ListNode? list1, ListNode? list2) {
        ListNode head = new ListNode();
        ListNode current = head;

        while (list1 != null && list2 != null) {
            if (list1.val < list2.val) {
                current.next = list1;
                list1 = list1.next;
            } else {
                current.next = list2;
                list2 = list2.next;
            }

            current = current.next;
            current.next = null;
        }

        current.next = list1 ?? list2;

        return head.next;
    }
}