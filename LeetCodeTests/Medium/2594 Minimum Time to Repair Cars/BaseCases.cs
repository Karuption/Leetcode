using LeetCode.Medium._2594_Minimum_Time_to_Repair_Cars;

namespace LeetCodeTests.Medium._2594_Minimum_Time_to_Repair_Cars;

public class BaseCases {
    [Theory]
    [InlineData(new[] { 5, 1, 8 }, 6, 16)]
    [InlineData(new[] { 4, 2, 3, 1 }, 10, 16)]
    [InlineData(
        new[] {
            5, 4, 3, 4, 10, 5, 5, 4, 5, 5, 3, 7, 8, 7, 6, 2, 10, 10, 4, 1, 3, 3, 4, 3, 8, 5, 8, 3, 6, 9, 1, 8, 9, 7, 2,
            8, 7, 1, 5, 7, 10, 5, 9, 5, 5, 6, 8, 6
        }, 18, 4)]
    public void BaseCase(int[] ranks, int cars, int expected) {
        var sut = new Solution();
        var actual = sut.RepairCars(ranks, cars);

        Assert.Equal(expected, actual);
    }
}