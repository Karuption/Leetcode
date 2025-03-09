using LeetCode.Medium._3208_Alternating_Groups_II;
namespace LeetCodeTests.Medium._3208_Alternating_Groups_II;

public class BaseCases {
    [Theory]
    [InlineData(new[] { 0, 1, 0, 1, 0 }, 3, 3)]
    [InlineData(new[] { 0, 1, 0, 0, 1, 0, 1 }, 6, 2)]
    [InlineData(new[] { 1, 1, 0, 1 }, 4, 0)]
    public void BaseCase(int[] input, int k, int expected) {
        var sut = new Solution();
        var result = sut.NumberOfAlternatingGroups(input, k);
        Assert.Equal(expected, result);
    }
}