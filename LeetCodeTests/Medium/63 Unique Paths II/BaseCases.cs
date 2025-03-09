using System.Reflection.Metadata.Ecma335;
using LeetCode.Medium._63_Unique_Paths_II;

namespace LeetCodeTests.Medium._63_Unique_Paths_II; 

public class BaseCases {
    [Theory]
    [MemberData(nameof(Leetcode))]
    public void BaseCase(int[][] grid, int expected) {
        Solution sut = new();

        var actual = sut.UniquePathsWithObstacles(grid);
        
        Assert.Equal(expected, actual);
    }
    
    [Theory]
    [MemberData(nameof(Leetcode))]
    public void BaseCaseDFS(int[][] grid, int expected) {
        Solution sut = new();

        var actual = sut.UniquePathsWithObstacles_DFS(grid);
        
        Assert.Equal(expected, actual);
    }
    
    public static List<Object[]> Leetcode() {
        var list = new List<object[]>();
    
        list.Add(new object[]{new int[][]{new[]{0,0,0},new[]{0,1,0},new[]{0,0,0}}, 2});
        list.Add(new Object[]{new int[][]{new[]{0,1}, new[]{0,0}}, 1});
        list.Add(new Object[]{new int[][]{new[]{0}, new[]{0}}, 1});
        list.Add(new Object[]{new int[][]{new[]{0,1}}, 0});
        list.Add(new Object[]{new int[][]{new[]{0}, new[]{0},new[]{0},new[]{0},new[]{0},new[]{0},new[]{0},new[]{0},
            new[]{0},new[]{0},new[]{0},new[]{0},new[]{0},new[]{0},new[]{0},new[]{0},new[]{0},new[]{0},new[]{0},new[]{0}}, 1});
    
        return list;
    }
}