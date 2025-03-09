using LeetCode.Medium._547_Number_of_Provinces;

namespace LeetCodeTests.Medium._547_Number_of_Provinces;

public class BaseCases {
    private static readonly int[][] case1 = { new[] { 1, 1, 0 }, new[] { 1, 1, 0 }, new[] { 0, 0, 1 } };
    private static readonly int[][] case2 = { new[] { 1, 0, 0 }, new[] { 0, 1, 0 }, new[] { 0, 0, 1 } };

    [Fact]
    public void BaseCase1() {
        Solution sut = new();

        var actual = sut.FindCircleNum(case1);

        Assert.Equal(2, actual);
    }

    [Fact]
    public void BaseCase2() {
        Solution sut = new();

        var actual = sut.FindCircleNum(case2);

        Assert.Equal(3, actual);
    }
}
