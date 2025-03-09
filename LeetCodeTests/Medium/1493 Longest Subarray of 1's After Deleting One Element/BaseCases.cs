using LeetCode.Medium._1493_Longest_Subarray_of_1_s_After_Deleting_One_Element;

namespace LeetCodeTests.Medium._1493_Longest_Subarray_of_1_s_After_Deleting_One_Element;

public class BaseCases {
    [Theory]
    [InlineData(new[] { 1, 1, 0, 1 }, 3)]
    [InlineData(new[] { 1, 1, 0, 0, 0 }, 2)]
    [InlineData(new[] { 0, 1, 1, 1, 0, 1, 1, 0, 1 }, 5)]
    [InlineData(new[] { 0, 1, 0, 1, 0, 0, 1, 1, 0, 1, 1 }, 4)]
    [InlineData(new[] { 1, 1, 1 }, 2)]
    [InlineData(new[] { 0, 0, 0, 0 }, 0)]
    [InlineData(new[] { 1, 1, 0, 0, 1, 1, 1, 0, 1 }, 4)]
    [InlineData(new[] { 0, 1, 1, 1, 0, 0, 1, 1, 0 }, 3)]
    public void Cases(int[] ar, int expected) {
        Solution sut = new();

        var actual = sut.LongestSubarray(ar);

        Assert.Equal(expected, actual);
    }
}