using Leetcode.Hard._834_Sum_of_Distances_in_Tree;

namespace LeetCodeTests.Hard._834_Sum_of_Distances_in_Tree;

public class BaseCases {
    [Fact]
    public void BaseCase1() {
        var n = 6;
        int[][] edges = { new[] { 0, 1 }, new[] { 0, 2 }, new[] { 2, 3 }, new[] { 2, 4 }, new[] { 2, 5 } };
        int[] expected = { 8, 12, 6, 10, 10, 10 };

        Solution sut = new();

        var actual = sut.SumOfDistancesInTree(n, edges);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void BaseCase2() {
        var n = 1;
        int[][] edges = { Array.Empty<int>() };
        int[] expected = { 0 };

        Solution sut = new();
        var actual = sut.SumOfDistancesInTree(n, edges);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void BaseCase3() {
        var n = 2;
        int[][] edges = { new[] { 1, 0 } };
        int[] expected = { 1, 1 };

        Solution sut = new();

        var actual = sut.SumOfDistancesInTree(n, edges);

        Assert.Equal(expected, actual);
    }
}