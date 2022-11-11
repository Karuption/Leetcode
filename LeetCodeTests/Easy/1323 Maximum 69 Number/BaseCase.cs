using Leetcode.Easy._1323_Maximum_69_Number;

namespace LeetCodeTests.Easy._1323_Maximum_69_Number;

public class BaseCase {
    [Theory]
    [InlineData(9996, 9999)]
    [InlineData(9669, 9969)]
    public void BaseCases(int input, int expected) {
        Solution sut = new();

        var result = sut.Maximum69Number(input);

        Assert.Equal(expected, result);
    }
}
