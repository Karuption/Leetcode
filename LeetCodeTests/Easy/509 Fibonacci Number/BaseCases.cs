using LeetCode.Easy._509_Fibonacci_Number;

namespace LeetCodeTests.Easy._509_Fibonacci_Number;

public class BaseCases {
    [Theory]
    [InlineData(2, 1)]
    [InlineData(3, 2)]
    [InlineData(4, 3)]
    [InlineData(0, 0)]
    public void BaseCase(int n, int expected) {
        var sut = new Solution();

        var result = sut.Fib(n);

        Assert.Equal(expected, result);
    }
}
