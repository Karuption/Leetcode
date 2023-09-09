using Leetcode.Hard._42_Trapping_Rain_Water;

namespace LeetCodeTests.Hard._42_Trapping_Rain_Water; 

public class SolutionTests {
    [InlineData(new[]{0,1,0,2,1,0,1,3,2,1,2,1}, 6)]

    [InlineData(new []{4,2,0,3,2,5}, 9)]
    [Theory]
    public void SolutionBaseCases(int[] height, int expected) {
        var sut = new Solution();
        var actual = sut.Trap(height);
        
        Assert.Equal(expected, actual);
    }
}