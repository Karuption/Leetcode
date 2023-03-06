
using Leetcode.Easy._1539_Kth_Missing_Positive_Number;

namespace LeetCodeTests.Easy._1539_Kth_Missing_Positive_Number;

public class BaseCases {

    [Theory]
    [InlineData(new[] { 2, 3, 4, 7, 11 }, 5, 9)]
    [InlineData(new[] { 1, 2, 3, 4 }, 2, 6)]
    [InlineData(new[]{5, 6, 7, 8, 9},9,14)]
    public void BaseCase(int[] arr, int k, int expected) {
        var solution = new Solution();
        var actual = solution.FindKthPositive(arr, k);
        Assert.Equal(expected, actual);
    }
}