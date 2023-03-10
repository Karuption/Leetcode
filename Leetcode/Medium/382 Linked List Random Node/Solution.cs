namespace Leetcode.Medium._382_Linked_List_Random_Node; 


// Definition for singly-linked list.
 public class ListNode {
     public int val;
     public ListNode next;
     public ListNode(int val=0, ListNode next=null) {
         this.val = val;
         this.next = next;
     }
 }
 
public class Solution {
    private ListNode _head;
    private int _count;
    
    public Solution(ListNode head) {
        _head = head;
        _count = 0;
        var current = head;
        while (current != null) {
            current = current.next;
            _count++;
        }
    }
    
    public int GetRandom() {
        var pick = Random.Shared.Next(0, _count);
        var current = _head;
        
        while (current != null && pick!=0) {
            current = current.next;
            pick--;
        }

        return current.val;
    }
}