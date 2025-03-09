using LeetCode.Hard._4_Median_of_Two_Sorted_Arrays;

namespace LeetCodeTests.Hard._4_Median_of_Two_Sorted_Arrays;

public class ExtendedCases {
    [Theory]
    [InlineData(new[] { 1 }, new[] { 2, 3, 4 }, 2.5)]
    [InlineData(new[] { 2, 3, 4 }, new[] { 1 }, 2.5)]
    [InlineData(new[] { 3, 4 }, new[] { 1, 2 }, 2.5)]
    public void NeverGetToMedianBeforeEndOfSpace(int[] num1, int[] num2, double expected) {
        Solution sut = new();

        var result = sut.FindMedianSortedArrays(num1, num2);

        Assert.Equal(expected, result);
    }
}
