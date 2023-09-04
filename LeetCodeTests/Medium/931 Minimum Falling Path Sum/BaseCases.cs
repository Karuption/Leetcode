using Leetcode.Medium._931_Minimum_Falling_Path_Sum;

namespace LeetCodeTests.Medium._931_Minimum_Falling_Path_Sum; 

public class BaseCases {
    
    [Fact]
    public void BaseCase1() {
        var matrix = new int[][]{new[]{2,1,3},new[]{6,5,4},new[]{7,8,9}};
        var expected = 13;

        var sut = new Solution();
        var actual = sut.MinFallingPathSum(matrix);
        
        Assert.Equal(expected,  actual);
    }

    [Fact]
    public void BaseCase2() {
        var matrix = new int[][] { new[] { -19, 57 }, new[] { -40, -5 } };
        var expected = -59;

        var sut = new Solution();
        var actual = sut.MinFallingPathSum(matrix);
        
        Assert.Equal(expected,  actual);
    }
    
    [Fact]
    public void BaseCase3() {
        var matrix = new int[][]{new []{100,-42,-46,-41},new []{31,97,10,-10},new []{-58,-51,82,89},new []{51,81,69,-51}};
        var expected = -36;

        var sut = new Solution();
        var actual = sut.MinFallingPathSum(matrix);
        
        Assert.Equal(expected,  actual);
    }
}