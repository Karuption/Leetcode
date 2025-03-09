using LeetCode.Easy._1971._Find_if_Path_Exists_in_Graph;

namespace LeetCodeTests.Easy._1971_Find_if_Path_Exists_in_Graph;

public class BaseCases {
    [Fact]
    public void BaseCase() {
        var edges = new[] {
            new[] { 0, 1 }, new[] { 1, 2 }, new[] { 2, 0 }
        };

        var source = 0;
        var destination = 2;

        Solution sut = new();

        var actual = sut.ValidPath(3, edges, source, destination);

        Assert.True(actual);
    }

    [Fact]
    public void BaseCase2() {
        var Solution = new Solution();

        var edges = new[] {
            new[] { 0, 1 }, new[] { 0, 2 }, new[] { 3, 5 }, new[] { 5, 4 }, new[] { 4, 3 }
        };

        var source = 0;
        var destination = 5;

        Solution sut = new();

        var actual = sut.ValidPath(6, edges, source, destination);

        Assert.False(actual);
    }

    [Fact]
    public void BaseCase3() {
        var Solution = new Solution();

        var edges = new[] {
            new[] { 4, 3 }, new[] { 1, 4 }, new[] { 4, 8 }, new[] { 1, 7 }, new[] { 6, 4 }, new[] { 4, 2 },
            new[] { 7, 4 }, new[] { 4, 0 }, new[] { 0, 9 }, new[] { 5, 4 }
        };

        var source = 5;
        var destination = 9;

        Solution sut = new();

        var actual = sut.ValidPath(10, edges, source, destination);

        Assert.True(actual);
    }
}
