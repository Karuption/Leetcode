using LeetCode.Medium._1358_Number_of_Substrings_Containing_All_Three_Characters;
namespace LeetCodeTests.Medium._1358_Number_of_Substrings_Containing_All_Three_Characters;

public class BaseCases {
    [Theory]
    [InlineData("abcabc", 10)]
    [InlineData("aaacb", 3)]
    [InlineData("abc", 1)]
    public void BaseCase(string s, int expected) {
        var sut = new Solution();
        var actual = sut.NumberOfSubstrings(s);
        
        Assert.Equal(expected, actual);
    }
}