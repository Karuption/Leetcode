using LeetCode.Medium._221_Maximal_Square;

namespace LeetCodeTests.Medium._221_Maximal_Square; 

public class BaseCases {
    [Fact]
    public void BaseCase1() {
        var matrix = new []{new []{'1', '0', '1', '0', '0'}, new []{'1', '0', '1', '1', '1'}, new []{'1', '1', '1', '1', '1'}, new []{'1', '0', '0', '1', '0'}};
        var expected = 4;

        var sut = new Solution();
        var actual = sut.MaximalSquare(matrix);
        
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void BaseCase2() {
        var matrix = new[]{new[]{'0', '1'}, new[]{'1', '0'}};
        var expected = 1;

        var sut = new Solution();
        var actual = sut.MaximalSquare(matrix);
        
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void BaseCase3() {
        var matrix = new[]{new[]{'0'}};
        var expected = 0;

        var sut = new Solution();
        var actual = sut.MaximalSquare(matrix);
        
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void BaseCase4() {
        var matrix = new[]{new[]{'0', '1'}};
        var expected = 1;

        var sut = new Solution();
        var actual = sut.MaximalSquare(matrix);
        
        Assert.Equal(expected, actual);
    }
    [Fact]
    public void BaseCase6() {
        var matrix = new[]{new[]{'0','0','1','0'},new[]{'1','1','1','1'},new[]{'1','1','1','1'},new[]{'1','1','1','0'},new[]{'1','1','0','0'},new[]{'1','1','1','1'},new[]{'1','1','1','0'}};
        var expected = 9;

        var sut = new Solution();
        var actual = sut.MaximalSquare(matrix);
        
        Assert.Equal(expected, actual);
    }
}