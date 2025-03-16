using LeetCode.Medium._2560_House_Robber_IV;
namespace LeetCodeTests.Medium._2560_House_Robber_IV;

public class BaseCases {
    [Theory]
    [InlineData(new[] { 2, 3, 5, 9 }, 2, 5)]
    [InlineData(new[] { 2, 7, 9, 3, 1 }, 2, 2)]
    [InlineData(new[] { 2, 7, 9, 1, 3 }, 2, 2)]
    public void TestCase1(int[] input, int k, int expected) {
        var sut = new Solution();
        var actual = sut.MinCapability(input, k);
        
        Assert.Equal(expected, actual);
    }
}