using LeetCode.Medium._223_Rectangle_Area;

namespace LeetCodeTests.Medium._223_Rectangle_Area;

public class BaseCases {
    [Theory]
    [InlineData(-3, 0, 3, 4, 0, -1, 9, 2, 45)]
    [InlineData(-2, -2, 2, 2, -2, -2, 2, 2, 16)]
    [InlineData(-2, -2, 2, 2, 3, 3, 4, 4, 17)]
    [InlineData(2, 2, -2, -2, -3, -3, -4, -4, 17)]
    public void BaseCase(int ax1, int ay1, int ax2, int ay2, int bx1, int by1, int bx2, int by2, int expected) {
        Solution sut = new();

        var actual = sut.ComputeArea(ax1, ay1, ax2, ay2, bx1, by1, bx2, by2);

        Assert.Equal(expected, actual);
    }
}
