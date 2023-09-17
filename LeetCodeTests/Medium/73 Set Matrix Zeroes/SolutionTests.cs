using Leetcode.Medium._73_Set_Matrix_Zeroes;
namespace LeetCodeTests.Medium._73_Set_Matrix_Zeroes; 

public class SolutionTests {

    [Theory]
    [MemberData(nameof(DefaultCases))]
    public void BaseCases(int[][] actual, int[][] expected) {
        var sut = new Solution();
        sut.SetZeroes(actual);
        
        Assert.Equal(expected, actual);
    }
    
    public static IEnumerable<Object[]> DefaultCases() {
        List<Object[]> output = new();
        output.Add(
            new object[] {
                new[] { new[] { 1, 1, 1 }, new[] { 1, 0, 1 }, new[] { 1, 1, 1 } },
                new[] { new[] { 1, 0, 1 }, new[] { 0, 0, 0 }, new[] { 1, 0, 1 } }
            });
        output.Add(
            new object[] {
                new[] { new[] { 0, 1, 2, 0 }, new[] { 3, 4, 5, 2 }, new[] { 1, 3, 1, 5 } },
                new[] { new[] { 0, 0, 0, 0 }, new[] { 0, 4, 5, 0 }, new[] { 0, 3, 1, 0 } }
            });

        return output;
    }
}