using Leetcode.Hard._23_Merge_k_Sorted_Lists;

namespace LeetCodeTests.Hard._23_Merge_k_Sorted_Lists; 

public class BaseCases {
    [Fact]
    public void BaseCase1() {
        var input = new ListNode[] {
            new(1, new(4, new(5))),
            new(1, new(3, new(4))),
            new(2, new(6))
        };

        var sut = new Solution();
        var actual = sut.MergeKLists(input);
        
        //Output: [1,1,2,3,4,4,5,6]
        ListNode expected = new(1, new(1, new(2, new(3, new(4, new(4, new(5, new(6))))))));
        Assert.Equal(expected, actual, new ListComparer());
    }
    
    [Fact]
    public void BaseCase2() {
        var input = new ListNode[] {
            new(1, new(3, new(4))),
            new(1, new(4, new(5))),
            new(2, new(6))
        };

        var sut = new Solution();
        var actual = sut.MergeKLists(input);
        
        //Output: [1,1,2,3,4,4,5,6]
        ListNode expected = new(1, new(1, new(2, new(3, new(4, new(4, new(5, new(6))))))));
        Assert.Equal(expected, actual, new ListComparer());
    }

    //Input: lists = []
    //Output: []
    [Fact]
    public void BaseCase3() {
        var sut = new Solution();
        var actual = sut.MergeKLists(Array.Empty<ListNode>());
        
        Assert.Equal(null, actual, new ListComparer());
    }
}

public class ListComparer:IEqualityComparer<ListNode> {
    public bool Equals(ListNode x, ListNode y) {
        if (x is null && y is null)
            return true;
        if (ReferenceEquals(x, null))
            return false;
        if (ReferenceEquals(y, null))
            return false;
        if (x.GetType() != y.GetType())
            return false;
        return x.val == y.val && this.Equals(x.next,y.next);
    }

    public int GetHashCode(ListNode obj) {
        return HashCode.Combine(obj.val, obj.next);
    }
}