using LeetCode.Medium._128_Longest_Consecutive_Sequence;

namespace LeetCodeTests.Medium._128_Longest_Consecutive_Sequence; 

public class SolutionTests {
    [Theory]
    [InlineData(new[] { 100, 4, 200, 1, 3, 2 }, 4)]
    [InlineData(new[] { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 }, 9)]
    [InlineData(new[] { 0 }, 1)]
    [InlineData(new int[0], 0)]
    public void BaseCases(int[] nums,int expected) {
        var sut = new Solution();
        var actual = sut.LongestConsecutive(nums);
        
        Assert.Equal(expected, actual);
    }
}