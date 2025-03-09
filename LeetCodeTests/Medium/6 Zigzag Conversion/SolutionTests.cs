using LeetCode.Medium._6_Zigzag_Conversion;

namespace LeetCodeTests.Medium._6_Zigzag_Conversion;

public class SolutionTests {
    [Theory]
    [InlineData("PAYPALISHIRING", 3, "PAHNAPLSIIGYIR")]
    [InlineData("PAYPALISHIRING", 4, "PINALSIGYAHRPI")]
    [InlineData("A", 1, "A")]
    public void BaseCases(string s, int numRows, string expected) {
        var sut = new Solution();
        var actual = sut.Convert(s, numRows);
        
        Assert.Equal(expected, actual);
    }
}