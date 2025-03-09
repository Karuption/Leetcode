using LeetCode.Medium._740_Delete_and_Earn;

namespace LeetCodeTests.Medium._740_Delete_and_Earn;

public class BaseCases {
    [Theory]
    [InlineData(new[] { 3, 4, 2 }, 6)]
    [InlineData(new[] { 2, 2, 3, 3, 3, 4 }, 9)]
    public void BaseCase(int[] input, int expected) {
        Solution sut = new();
        var actual = sut.DeleteAndEarn(input);

        Assert.Equal(expected, actual);
    }
}
