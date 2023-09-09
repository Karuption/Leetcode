using Leetcode.Medium._12_Integer_to_Roman;
namespace LeetCodeTests.Medium._12._Integer_to_Roman;

public class SolutionTests {
    [InlineData(3, "III")]
    [InlineData(58, "LVIII")]
    [InlineData(1994, "MCMXCIV")]
    [Theory]
    public void BaseCases(int num, string expected) {
        var sut = new Solution();
        var actual = sut.IntToRoman(num);
        
        Assert.Equal(expected, actual);
    }
}