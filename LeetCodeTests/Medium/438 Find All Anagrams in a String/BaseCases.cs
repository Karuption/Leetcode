using Leetcode.Medium._438_Find_All_Anagrams_in_a_String;

namespace LeetCodeTests.Medium;

public class BaseCases {
    [Theory]
    [InlineData("cbaebabacd", "abc", new[] { 0, 6 })]
    [InlineData("abab", "ab", new[] { 0, 1, 2 })]
    [InlineData("aaaaaaaaaaaaa", "aaaaaaaaaa", new[] { 0, 1, 2, 3 })]
    [InlineData("aa", "bb", new int[] { })]
    [InlineData("baa", "aa", new[] { 1 })]
    public void BaseCase(string s, string p, int[] expected) {
        Solution sut = new();

        var actual = sut.FindAnagrams(s, p);

        Assert.Equal(expected, actual);
    }
}
