using Leetcode._4_Median_of_Two_Sorted_Arrays;

namespace LeetCodeTests._4_Median_of_Two_Sorted_Arrays;

public class BaseCases {
    [Fact]
    public void BaseCase1() {
        Solution sut = new();

        double result = sut.FindMedianSortedArrays(new[] { 1d, 3d }, new[] { 2d });

        Assert.Equal(2, result);
    }

    [Fact]
    public void BaseCase2() {
        Solution sut = new();

        double result = sut.FindMedianSortedArrays(new[] { 1d, 2d }, new[] { 3d, 4d });

        Assert.Equal(2.5, result);
    }
}
