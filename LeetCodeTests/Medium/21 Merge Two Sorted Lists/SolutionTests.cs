using LeetCode.Medium._21_Merge_Two_Sorted_Lists;
using LeetCodeTests.Helpers;

namespace LeetCodeTests.Medium._21_Merge_Two_Sorted_Lists; 

public class SolutionTests {
    [Theory]
    [InlineData(new[] { 1, 2, 4 }, new[] { 1, 3, 4 }, new[] { 1, 1, 2, 3, 4, 4 })]
    [InlineData(new int[] { }, new int[] { }, new int[] { })]
    [InlineData(new int[] { }, new[] { 0 }, new[] { 0 })]
    public void BaseCases(int[] input1, int[] input2, int[] expected) {
        var list1 = input1.ToListNode();
        var list2 = input2.ToListNode();
        
        var sut = new Solution();
        var actual = sut.MergeTwoLists(list1, list2);
        
        Assert.Equal(expected, actual?.ToArray() ?? []);
    }
}