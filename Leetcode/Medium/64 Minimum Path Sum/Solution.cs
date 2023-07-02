namespace Leetcode.Medium._64_Minimum_Path_Sum; 

public class Solution {
    private int[,] _memo;
    public int MinPathSum(int[][] grid) {
        _memo = new int[grid.Length,grid[0].Length];
        return MinPathSum(grid, 0, 0);
    }

    int MinPathSum(int[][] grid, int i, int j) {
        if (i == grid.Length - 1 && j == grid[0].Length - 1)
            return grid[i][j];

        if (i >= grid.Length || j >= grid[0].Length)
            return int.MaxValue;

        if (_memo[i,j] > 0)
            return _memo[i,j];
        
        _memo[i,j] = grid[i][j] + Math.Min(MinPathSum(grid, i + 1, j), MinPathSum(grid, i, j + 1));

        return _memo[i, j];
    }
}