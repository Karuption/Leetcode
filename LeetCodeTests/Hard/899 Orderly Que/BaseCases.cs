using Leetcode.Hard._899_Orderly_Que;

namespace LeetCodeTests.Hard._899_Orderly_Que;

public class BaseCases {
    [Fact]
    public void CBA_ShouldReturn_ACB() {
        Solution sut = new();

        var result = sut.OrderlyQueue("cba", 1);

        Assert.Equal("acb", result, StringComparer.InvariantCulture);
    }

    [Fact]
    public void BAACA_ShouldReturn_AAABC() {
        Solution sut = new();

        var result = sut.OrderlyQueue("baaca", 3);

        Assert.Equal("aaabc", result, StringComparer.InvariantCulture);
    }
}