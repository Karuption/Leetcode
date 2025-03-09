using LeetCode.LeetCodeTypes;
using LeetCode.Medium._129_Sum_Root_to_Leaf_Numbers;
using LeetCodeTests.Helpers;

namespace LeetCodeTests.Medium._129_Sum_Root_to_Leaf_Numbers;

public class BaseCases {
    [Theory]
    [InlineData(new[] { 1, 2, 3 }, 25)]
    [InlineData(new[] { 4, 9, 0, 5, 1 }, 1026)]
    public void BaseCase(int[] nums, int expected) {
        var sut = new Solution();

        var actual = sut.SumNumbers(nums.ToTree());
        Assert.Equal(expected, actual);
    }
}
