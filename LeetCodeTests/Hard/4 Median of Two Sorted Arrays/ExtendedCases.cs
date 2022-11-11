using Leetcode.Hard._4_Median_of_Two_Sorted_Arrays;

namespace LeetCodeTests.Hard._4_Median_of_Two_Sorted_Arrays;

public class ExtendedCases {
    [Theory]
    [InlineData(new[] { 1d }, new[] { 2d, 3d, 4d }, 2.5)]
    [InlineData(new[] { 2d, 3d, 4d }, new[] { 1d }, 2.5)]
    [InlineData(new[] { 3d, 4d }, new[] { 1d, 2d }, 2.5)]
    public void NeverGetToMedianBeforeEndOfSpace(double[] num1, double[] num2, double expected) {
        Solution sut = new();

        var result = sut.FindMedianSortedArrays(num1, num2);

        Assert.Equal(2.5, result);
    }
}
