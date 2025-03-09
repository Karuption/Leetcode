using LeetCode.Medium._684_Redundant_Connection;

namespace LeetCodeTests.Medium._684_Redundant_Connection;

public class BaseCases {
    // Input: edges = [[1,2],[1,3],[2,3]]
    // Output: [2,3]

    [Fact]
    public void BaseCase1() {
        var sut = new Solution();
        var actual = sut.FindRedundantConnection(new[] {
            new[] { 1, 2 },
            new[] { 1, 3 },
            new[] { 2, 3 }
        });
        Assert.True(new[] { 2, 3 }.SequenceEqual(actual!));
    }

    // Input: edges = [[1,2],[2,3],[3,4],[1,4],[1,5]]
    // Output: [1,4]

    [Fact]
    public void BaseCase2() {
        var sut = new Solution();
        var actual = sut.FindRedundantConnection(new[] {
            new[] { 1, 2 },
            new[] { 2, 3 },
            new[] { 3, 4 },
            new[] { 1, 4 },
            new[] { 1, 5 }
        });

        Assert.True(new[] { 1, 4 }.SequenceEqual(actual!));
    }
}
