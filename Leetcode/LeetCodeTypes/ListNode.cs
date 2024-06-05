using System.Collections;
using System.Diagnostics;

namespace Leetcode.LeetCodeTypes;

[DebuggerTypeProxy(typeof(ListNodeDebugView))]
[DebuggerDisplay("{ToString(),raw}")]
public class ListNode : IEnumerable<int> {
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

    public override string ToString() {
        return $"Value: {val}";
    }
}

public struct ListNodeEnumerator : IEnumerator<int> {
    public int Current => (int)_currentListNode?.val!;
    object IEnumerator.Current => Current;
    
    private readonly ListNode? _head;
    private ListNode? _currentListNode;

    public ListNodeEnumerator(ListNode head) {
        _currentListNode = _head = new(0, head);
    }
    public bool MoveNext() {
        _currentListNode = _currentListNode?.next;
        return _currentListNode is not null;
    }

    public void Reset() {
        _currentListNode = _head;
    }

    public void Dispose() {  }
}

internal sealed class ListNodeDebugView {
    private readonly ListNode _head;
    [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
    public int[] Nodes => _head.ToArray();
    public ListNodeDebugView(ListNode node) {
        _head = node;
    }
}