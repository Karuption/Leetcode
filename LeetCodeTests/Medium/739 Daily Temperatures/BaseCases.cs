using Leetcode.Medium._739_Daily_Temperatures;

namespace LeetCodeTests.Medium._739_Daily_Temperatures;

public class BaseCases {
    [Theory]
    [InlineData(new[] { 73, 74, 75, 71, 69, 72, 76, 73 }, new[] { 1, 1, 4, 2, 1, 1, 0, 0 })]
    [InlineData(new[] { 30, 40, 50, 60 }, new[] { 1, 1, 1, 0 })]
    [InlineData(new[] { 30, 60, 90 }, new[] { 1, 1, 0 })]
    public void Test_Daily_Temperatures(int[] input, int[] expected) {
        Solution sut = new();

        var actual = sut.DailyTemperatures(input);

        Assert.Equal(expected, actual, EqualityComparer<int>.Default);
    }
}
