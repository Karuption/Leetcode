using LeetCode.Easy._2379._Minimum_Recolors_to_Get_K_Consecutive_Black_Blocks;

namespace LeetCodeTests.Easy._2379_Minimum_Recolors_to_Get_K_Consecutive_Black_Blocks;

public class BaseTests {

    [Theory]
    [InlineData("WBBWWBBWBW", 7, 3)]
    [InlineData("WBWBBBW", 2, 0)]
    public void BaseLineTests(string input, int k, int expected) {
        var sut = new Solution();
        var actual = sut.MinimumRecolors(input, k);
        
        Assert.Equal(expected, actual);
    }
}