using System.Collections;

namespace Leetcode.LeetCodeTypes;

public class ListNode:IEnumerable<int> {
    public int val;
    public ListNode? next;

    public ListNode(int val = 0, ListNode? next = null) {
        this.val = val;
        this.next = next;
    }

    public IEnumerator<int> GetEnumerator() {
        return new ListNodeEnumerator(this);
    }

    IEnumerator IEnumerable.GetEnumerator() {
        return GetEnumerator();
    }
}

public struct ListNodeEnumerator:IEnumerator<int> {
    public int Current => (int)_currentListNode?.val!;
    object IEnumerator.Current => Current;
    private readonly ListNode _head;
    private ListNode _currentListNode;

    public ListNodeEnumerator(ListNode head) {
        _currentListNode = _head = new(0, head);
    }
    public bool MoveNext() {
        if (!(_currentListNode?.next is { } node)) {
            return false;
        } 
        _currentListNode = node;
        return true;
    }

    public void Reset() {
        _currentListNode = _head;
    }

    public void Dispose() {  }
}