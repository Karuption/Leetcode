using LeetCode.Easy._746_Min_Cost_Climbing_Stairs;

namespace LeetCodeTests.Easy._746_Min_Cost_Climbing_Stairs;

public class BaseCases {
    [Theory]
    [InlineData(new[] { 10, 15, 20 }, 15)]
    [InlineData(new[] { 1, 100, 1, 1, 1, 100, 1, 1, 100, 1 }, 6)]
    [InlineData(new[] { 0, 2, 2, 1 }, 2)]
    [InlineData(new[] { 1, 100 }, 1)]
    public void BaseCase(int[] input, int expected) {
        Solution sut = new();

        var actual = sut.MinCostClimbingStairs(input);

        Assert.Equal(expected, actual);
    }
}
