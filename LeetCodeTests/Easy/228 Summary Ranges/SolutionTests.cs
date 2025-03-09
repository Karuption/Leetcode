using LeetCode.Easy._228_Summary_Ranges;

namespace LeetCodeTests.Easy._228_Summary_Ranges; 

public class SolutionTests {
    [Theory]
    [InlineData(new[] { 0, 1, 2, 4, 5, 7 }, new[] { "0->2", "4->5", "7" })]
    [InlineData(new[] { 0, 2, 3, 4, 6, 8, 9 }, new[] { "0", "2->4", "6", "8->9" })]
    [InlineData(new int[] { }, new string[] { })]
    public void BaseCases(int[] input, string[] expected) {
        var sut = new Solution();
        var actual = sut.SummaryRanges(input);
        
        Assert.Equal(expected, actual);
    }
}