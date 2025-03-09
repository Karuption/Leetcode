using LeetCode.Medium._886_Possible_Bipartition;

namespace LeetCodeTests.Medium._886_Possible_Bipartition;

public class BaseCases {
    [Fact]
    public void BaseCase1() {
        var expected = true;
        var n = 4;

        Solution sut = new();

        var dislikes = new[] { new[] { 1, 2 }, new[] { 1, 3 }, new[] { 2, 4 } };

        var actual = sut.PossibleBipartition(n, dislikes);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void BaseCase2() {
        var expected = false;
        var n = 3;

        Solution sut = new();

        var dislikes = new[] { new[] { 1, 2 }, new[] { 1, 3 }, new[] { 2, 3 } };

        var actual = sut.PossibleBipartition(n, dislikes);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void BaseCase3() {
        var expected = false;
        var n = 5;

        Solution sut = new();

        var dislikes = new[] { new[] { 1, 2 }, new[] { 2, 3 }, new[] { 3, 4 }, new[] { 4, 5 }, new[] { 1, 5 } };

        var actual = sut.PossibleBipartition(n, dislikes);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void BaseCase4() {
        var expected = true;
        var n = 10;

        Solution sut = new();

        var dislikes = new[]
            { new[] { 1, 2 }, new[] { 3, 4 }, new[] { 5, 6 }, new[] { 6, 7 }, new[] { 8, 9 }, new[] { 7, 8 } };

        var actual = sut.PossibleBipartition(n, dislikes);

        Assert.Equal(expected, actual);
    }
}
