using Leetcode.Easy._409._Longest_Palindrome;

namespace LeetCodeTests.Easy._409._Longest_Palindrome;

public class BaseCases {
    [Theory]
    [InlineData("abccccdd", 7)]
    [InlineData("a", 1)]
    public void BaseCase(string input, int expected) {
        Solution sut = new();
        var actual = sut.LongestPalindrome(input);
        
        Assert.Equal(expected, actual);
    }
}