using Leetcode.Easy._205_Isomorphic_Strings;
namespace LeetCodeTests.Easy._25_Isomorphic_Strings; 

public class SolutionTests {
    [Theory]
    [InlineData("egg", "add", true)]
    [InlineData("foo", "bar", false)]
    [InlineData("paper", "title", true)]
    [InlineData("badc", "baba", false)]
    public void BaseCases(string s, string t, bool expected) {
        var sut = new Solution();
        var actual = sut.IsIsomorphic(s, t);
        
        Assert.Equal(expected, actual);
    }
}