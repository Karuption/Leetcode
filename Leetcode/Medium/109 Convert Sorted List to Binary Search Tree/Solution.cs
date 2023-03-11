using System.Runtime.InteropServices;

namespace Leetcode.Medium._109_Convert_Sorted_List_to_Binary_Search_Tree; 

//Definition for singly-linked list.
public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}

//Definition for a binary tree node.
 public class TreeNode {
     public int val;
     public TreeNode left;
     public TreeNode right;
     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
         this.val = val;
         this.left = left;
         this.right = right;
     }
 }
 
//initial solution
// public class Solution {
//     public TreeNode SortedListToBST(ListNode head) {
//         if(head == null)
//             return null;
//         
//         List<ListNode> list = new ();
//         while (head != null) {
//             list.Add(head);
//             head = head.next;
//         }
//         
//         return subTree(CollectionsMarshal.AsSpan(list), 0, list.Count - 1);
//     }
//     
//     private TreeNode subTree(ReadOnlySpan<ListNode> list, int start, int end) {
//         if (start > end)
//             return null;
//         
//         var mid = (start + end) / 2;
//         var node = new TreeNode(list[mid].val);
//         node.left = subTree(list, start, mid - 1);
//         node.right = subTree(list, mid + 1, end);
//         
//         return node;
//     }

// solution with span slices instead of indexes.
// public class Solution {
//     public TreeNode SortedListToBST(ListNode head) {
//         if(head == null)
//             return null;
//         
//         List<ListNode> list = new ();
//         while (head != null) {
//             list.Add(head);
//             head = head.next;
//         }
//         
//         return subTree(CollectionsMarshal.AsSpan(list));
//     }
//     
//     private TreeNode subTree(ReadOnlySpan<ListNode> list) {
//         if(list.Length == 0)
//             return null; 
//             
//         var mid = list.Length / 2;
//         var node = new TreeNode(list[mid].val);
//
//         if(list.Length == 1)
//             return node;
//         
//         node.left = subTree(list.Slice(0, mid));
//         
//         if(mid!=list.Length-1)
//             node.right = subTree(list.Slice(mid+1));
//         
//         return node;
//     }

//solution with linked list instead of list
public class Solution {
    public TreeNode SortedListToBST(ListNode head) {
        if(head == null)
            return null;
        
        return getMid(head);
    }
    
    private TreeNode getMid(ListNode head) {
        if (head == null)
            return null; 
        
        ListNode previous = null;
        ListNode slow = head;
        ListNode fast = head;
        
        while (fast.next != null && fast.next.next != null) {
            previous = slow;
            slow = slow.next;
            fast = fast.next.next;
        }

        if(previous != null)
            previous.next = null; //prevent cycles and is destructive to the linked list.

        TreeNode root = new(slow.val);

        if(previous != null)
            root.left = getMid(head);

        root.right = getMid(slow?.next);
        
        return root;
    }
}