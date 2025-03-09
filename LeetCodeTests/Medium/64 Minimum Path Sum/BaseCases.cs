using System.Runtime.InteropServices;
using LeetCode.Medium._64_Minimum_Path_Sum;

namespace LeetCodeTests.Medium._64_Minimum_Path_Sum; 

public class BaseCases {

    [Theory]
    [MemberData(nameof(leetcodecases))]
    public void BaseCase(int[][] input, int expected) {
        var sut = new Solution();

        var actual = sut.MinPathSum(input);
        
        Assert.Equal(expected, actual);
    }
    
    [Theory]
    [MemberData(nameof(leetcodecases))]
    public void BaseCase_DFS(int[][] input, int expected) {
        var sut = new Solution();

        var actual = sut.MinPathSum_DFS(input);
        
        Assert.Equal(expected, actual);
    }

    public static List<object[]> leetcodecases() {
        var output = new List<object[]>();
        
        output.Add(new[]{(object)new int[][] { new[] { 1, 3, 1 }, new[] { 1, 5, 1 }, new[] { 4, 2, 1 } }, 7});
        output.Add(new[]{(object)new int[][] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 } }, 12});
        output.Add(new[]{(object)new int[][] { new[] { 1, 2 }, new[] { 1,1 } }, 3});

        return output;
    }
}