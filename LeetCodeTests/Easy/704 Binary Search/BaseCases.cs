using Leetcode.Easy._704_Binary_Search;

namespace LeetCodeTests.Easy._704_Binary_Search;

public class BaseCases {
    [Theory]
    [InlineData(new[] { -1, 0, 3, 5, 9, 12 }, 9, 4)]
    [InlineData(new[] { -1, 0, 3, 5, 9, 12 }, 2, -1)]
    public void BaseCase(int[] arr, int target, int expected) {
        var sut = new Solution();

        var actual = sut.Search(arr, target);
        Assert.Equal(expected, actual);
    }
}
