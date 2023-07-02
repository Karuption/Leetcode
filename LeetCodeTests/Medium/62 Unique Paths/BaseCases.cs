using Leetcode.Medium._62_Unique_Paths;
namespace LeetCodeTests.Medium._62_Unique_Paths; 

public class BaseCases {
    [Theory]
    [InlineData(19, 13, 86493225)]
    [InlineData(3, 7, 28)]
    [InlineData(3, 2, 3)]
    public void BaseCase(int m, int n, int expected) {
        var sut = new Solution();

        var actual = sut.UniquePaths(m, n);
        
        Assert.Equal(expected, actual);
    }
    
    [Theory]
    [MemberData(nameof(genCases))]
    public void GeneratedCase(int m, int n, int expected) {
        var sut = new Solution();

        var actual = sut.UniquePaths(m, n);
        
        Assert.Equal(expected, actual);
    }

    public static List<object[]> genCases() {
        var output = new List<object[]>();
        for (int i = 1; i <= 100; i++) {
            for (int j = 1; j <= 100; j++) {
                var top = factorial (i+j-2);
                var mFactorial = factorial(i-1);
                var nFactorial = factorial(j - 1);
                if (top != 0 && mFactorial != 0 && nFactorial != 0) {
                    try {
                        var bottom = uint.CreateChecked((uint)mFactorial * (uint)nFactorial);
                        var expected = int.CreateChecked(top / bottom);
                        output.Add(new object[] { i, j, expected });
                    }
                    catch {
                        break;
                    }
                }
            }
        }

        return output;
    }

    public static int factorial(int n) {
        int product = 1;
        for (int i = n; i >= 1; i--) {
            try {
                product = int.CreateChecked(product*i);
                if (product < n)
                    return 0;
            }
            catch {
                return 0;
            }
        }

        return product;
    }
}