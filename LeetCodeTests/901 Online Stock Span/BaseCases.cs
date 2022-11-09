using Leetcode._901_Online_Stock_Span;

namespace LeetCodeTests._901_Online_Stock_Span;

public class BaseCases {
    [Theory]
    [InlineData(new[] { 100, 80, 60, 70, 60, 75, 85 }, new[] { 1, 1, 1, 2, 1, 4, 6 })]
    private void BaseCase(int[] input, int[] expected) {
        var sut = new StockSpanner();
        var actual = new List<int>();

        foreach (var i in input)
            actual.Add(sut.Next(i));

        Assert.NotEmpty(actual);
        Assert.Equal(expected, actual);
    }
}
