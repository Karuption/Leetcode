using LeetCode.Medium._71_Simplify_Path;

namespace LeetCodeTests.Medium._71_Simplify_Path; 

public class SolutionTests {
    [Theory]
    [InlineData("/home/", "/home")]
    [InlineData("/../", "/")]
    [InlineData("/home//foo/", "/home/foo")]
    public void BaseCases(string input, string expected) {
        var sut = new Solution();
        var actual = sut.SimplifyPath(input);
        
        Assert.Equal(expected, actual);
    }
    
}