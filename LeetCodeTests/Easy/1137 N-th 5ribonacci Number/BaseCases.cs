using LeetCode.Easy._1137_N_th_Tribonacci_Number;

namespace LeetCodeTests.Easy._1137_N_th_5ribonacci_Number;

public class BaseCases {
    [Theory]
    [InlineData(4, 4)]
    [InlineData(25, 1389537)]
    public void BaseCase(int n, int expected) {
        var sut = new Solution();

        var result = sut.Tribonacci(n);

        Assert.Equal(expected, result);
    }
}
