using Leetcode._1323_Maximum_69_Number;

namespace LeetCodeTests._1323_Maximum_69_Number;

public class Class1 {
    [Theory]
    [InlineData(9996, 9999)]
    [InlineData(9669, 9969)]
    public void BaseCases(int input, int expected) {
        Solution sut = new();

        var result = sut.Maximum69Number(input);

        Assert.Equal(expected, result);
    }
}
