using Leetcode.LeetCodeTypes;
using Leetcode.Hard._25._Reverse_Nodes_in_k_Group;
using LeetCodeTests.Helpers;

namespace LeetCodeTests.Hard._25._Reverse_Nodes_in_k_Group;

public class BaseCases {
    [Theory]
    [InlineData(new[]{1, 2}, 2, new[]{2, 1})]
    [InlineData(new[]{1, 2, 3, 4, 5}, 2, new[]{2, 1, 4, 3, 5})]
    [InlineData(new[]{1, 2, 3, 4, 5}, 3, new[]{3, 2, 1, 4, 5})]
    public void BaseCase(int[] input, int k, int[] expected) {
        Solution sut = new();
        var actual = sut.ReverseKGroup(input.ToListNode(), k);
        
        Assert.Equal(expected, actual.ToArray());
    }
}