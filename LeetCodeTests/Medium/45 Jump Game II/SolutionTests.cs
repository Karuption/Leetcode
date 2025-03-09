using LeetCode.Medium._45_Jump_Game_II;

namespace LeetCodeTests.Medium._45_Jump_Game_II; 

public class SolutionTests {

    [InlineData(new[] { 2, 3, 1, 1, 4 }, 2)]
    [InlineData(new[] { 2, 3, 0, 1, 4 }, 2)]
    [Theory]
    public void BaseCases(int[] nums, int expected) {

        var sut = new Solution();
        var actual = sut.Jump(nums);
        
        Assert.Equal(expected, actual);
    }
}