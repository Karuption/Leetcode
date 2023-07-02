using Leetcode.Medium._62_Unique_Paths;
namespace LeetCodeTests.Medium._62_Unique_Paths; 

public class BaseCases {
    [Theory]
    [InlineData(19, 13, 86493225)]
    [InlineData(3, 7, 28)]
    [InlineData(3, 2, 3)]
    public void BaseCase(int m, int n, int expected) {
        var sut = new Solution();

        var actual = sut.UniquePaths(m, n);
        
        Assert.Equal(expected, actual);
    }
}