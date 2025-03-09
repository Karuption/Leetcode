using LeetCode.Easy._70_Climbing_Stairs;

namespace LeetCodeTests.Easy._70_Climbing_Stairs;

public class BaseCases {
    [Theory]
    [InlineData(2, 2)]
    [InlineData(3, 3)]
    [InlineData(5, 8)]
    [InlineData(44, 1134903170)]
    public void BaseCase(int input, int expected) {
        Solution sut = new();

        var actual = sut.ClimbStairs(input);

        Assert.Equal(expected, actual);
    }
}
