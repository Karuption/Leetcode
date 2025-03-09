using LeetCode.Medium._213_House_Robber_2;

namespace LeetCodeTests.Medium._213_House_Robber_2;

public class BaseCases {
    [Theory]
    [InlineData(new[] { 2, 3, 2 }, 3)]
    [InlineData(new[] { 1, 2, 3, 1 }, 4)]
    [InlineData(new[] { 1, 2, 3 }, 3)]
    [InlineData(new[] { 200, 3, 140, 20, 10 }, 340)]
    public void BaseCase(int[] input, int expected) {
        Solution sut = new();

        var actual = sut.Rob(input);

        Assert.Equal(expected, actual);
    }
}
