using LeetCode.Hard._135_Candy;

namespace LeetCodeTests.Hard._135_Candy; 

public class SolutionTests {
    [InlineData(new[]{7,8,8,7,6,5,4,3,2,1},39)]
    [InlineData(new[]{1,2,2,2,1},7)]
    [InlineData(new[]{1,2,1,4},6)]
    [InlineData(new[]{1,2,3,1},7)]
    [InlineData(new[]{9,8,8,8,7,6,5,4,3,2,3},34)]
    [InlineData(new[]{7,8,8,7,6,5,4,3,2,3},33)]
    [InlineData(new[]{1,2,2},4)]
    [InlineData(new[]{1,0,2},5)]
    [Theory]
    public void BaseCases(int[] ratings, int expected) {
        var sut = new Solution();
        var actual = sut.Candy(ratings);
        
        Assert.Equal(expected, actual);
    }
}