using Leetcode.Medium._142_Linked_List_Cycle_II;
namespace LeetCodeTests.Medium._142_Linked_List_Cycle_II;

public class BaseCases {
    [Theory]
    [InlineData(new int[] { 3, 2, 0, -4 }, 1)]
    [InlineData(new []{1,2}, 0)]
    [InlineData(new []{1}, -1)]
    public void BaseCase(int [] linkedList, int position) {
        var head = new ListNode(linkedList[0]);
        ListNode? last = head;
        ListNode? pos = (position == 0)
            ?head
            :null;
        
        for(int i = 1; i< linkedList.Length; i++) {
            var node = new ListNode(linkedList[i]);
            if (i != linkedList.Length - 1) {
                last.next = node;
            } else {
                last.next = node;
                node.next = pos;
            }
            last = node;
            if (i == position)
                pos = node;
        }
        
        var solution = new Solution();
        var result = solution.DetectCycle(head);
        
        Assert.Equal(pos, result);
    }
}