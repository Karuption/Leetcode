using LeetCode.Medium._274_H_Index;

namespace LeetCodeTests.Medium._274_H_Index; 

public class SolutionTests {
    [InlineData(new []{3,0,6,1,5}, 3)]
    [InlineData(new []{1,3,1}, 1)]
    [InlineData(new []{0}, 0)]
    [InlineData(new []{1000}, 1)]
    [InlineData(new []{1,0}, 1)]

    [Theory]
    public void BaseCases(int[] nums, int expected) {
        var sut = new Solution();

        var actual = sut.HIndex(nums);

        Assert.Equal(expected, actual);
    }    
}