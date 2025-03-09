using LeetCode.Hard._4_Median_of_Two_Sorted_Arrays;

namespace LeetCodeTests.Hard._4_Median_of_Two_Sorted_Arrays;

public class BaseCases {
    [Fact]
    public void BaseCase1() {
        Solution sut = new();

        double result = sut.FindMedianSortedArrays(new[] { 1, 3 }, new[] { 2 });

        Assert.Equal(2, result);
    }

    [Fact]
    public void BaseCase2() {
        Solution sut = new();

        double result = sut.FindMedianSortedArrays(new[] { 1, 2 }, new[] { 3, 4 });

        Assert.Equal(2.5, result);
    }
}
