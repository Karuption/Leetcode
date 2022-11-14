using Leetcode.Medium._947_Most_Stones_Removed_with_Same_Row_or_Column;

namespace LeetCodeTests.Medium._947_Most_Stones_Removed_with_Same_Row_or_Column;

public class BaseCases {
    private readonly int[][] arr =
        { new[] { 0, 0 }, new[] { 0, 1 }, new[] { 1, 0 }, new[] { 1, 2 }, new[] { 2, 1 }, new[] { 2, 2 } };

    private readonly int[][] arr1 = { new[] { 0, 0 }, new[] { 0, 2 }, new[] { 1, 1 }, new[] { 2, 0 }, new[] { 2, 2 } };

    [Fact]
    public void BaseCase() {
        Solution sut = new();

        var actual = sut.RemoveStones(arr);

        Assert.Equal(5, actual);
    }

    [Fact]
    public void BaseCase1() {
        Solution sut = new();

        var actual = sut.RemoveStones(arr1);

        Assert.Equal(3, actual);
    }

    [Fact]
    public void BaseCase2() {
        Solution sut = new();

        var actual = sut.RemoveStones(new[] { new[] { 0, 0 } });

        Assert.Equal(0, actual);
    }
}
