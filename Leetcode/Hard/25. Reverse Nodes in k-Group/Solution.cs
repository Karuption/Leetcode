using Leetcode.LeetCodeTypes;

namespace Leetcode.Hard._25._Reverse_Nodes_in_k_Group;

public class Solution {
    public ListNode ReverseKGroup(ListNode head, int k) {
        Stack<ListNode> stack = new(k);
        var current = head;
        ListNode? newHead = null;

        ListNode? previous = null;
        while (current is not null) {
            for (var i = 0; i < k && current is not null; i++) {
                stack.Push(current);
                current = current.next;
            }

            if (stack.Count < k)
                break;

            var peek = stack.Peek();
            newHead ??= peek;
            if (previous != null) previous.next = peek;

            while (stack.TryPop(out var curr)) {
                if (stack.TryPeek(out var next))
                    curr.next = next;
                else
                    previous = curr;
            }

            previous!.next = null;
        }

        while (stack.TryPop(out var segment) && previous is not null)
            previous.next = segment;
        
        return newHead!;
    }
}

