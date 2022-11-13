using Leetcode.Medium._98_House_Robber;

namespace LeetCodeTests.Medium._98_House_Robber;

public class BaseCases {
    [Theory]
    [InlineData(new[] { 2, 7, 9, 3, 1 }, 12)]
    [InlineData(new[] { 1, 2, 3, 1 }, 4)]
    [InlineData(new[] { 2, 1, 1, 2 }, 4)]
    public void BaseCase(int[] input, int expected) {
        Solution sut = new();

        var result = sut.Rob(input);

        Assert.Equal(expected, result);
    }
}
