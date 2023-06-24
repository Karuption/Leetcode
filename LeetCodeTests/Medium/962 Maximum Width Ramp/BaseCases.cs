using Leetcode.Medium._962_Maximum_Width_Ramp;

namespace LeetCodeTests.Medium._962_Maximum_Width_Ramp; 

public class BaseCases {
    [Theory]
    [InlineData(new[] { 6, 0, 8, 2, 1, 5 }, 4)]
    [InlineData(new[] { 9, 8, 1, 0, 1, 9, 4, 0, 4, 1 }, 7)]
    public void BaseCase(int[] input, int expected) {
        var sut = new Solution();

        var actual = sut.MaxWidthRamp(input);
        
        Assert.Equal(expected, actual);
    }
}