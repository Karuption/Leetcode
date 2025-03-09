namespace LeetCode.Medium._64_Minimum_Path_Sum; 

public class Solution {
    private int[][] _memo;

    public int MinPathSum(int[][] grid) {
        _memo = Enumerable.Range(0,2).Select(_=>Enumerable.Range(0,grid[0].Length).Select(_=>int.MaxValue).ToArray()).ToArray();

        _memo[0][0] = grid[0][0];
        for (int i = 1; i < grid[0].Length; i++) {
            _memo[0][i] = grid[0][i] + _memo[0][i-1];
        }
        
        for (int i = 1; i < grid.Length; i++) {
            _memo[i&1][0] = _memo[(i - 1)&1][0] + grid[i][0];
            for (int j = 1; j < grid[0].Length; j++) {
                _memo[i&1][j] = grid[i][j] + Math.Min(_memo[(i - 1)&1][j], _memo[i&1][j - 1]);
            }
        }

        return _memo[(grid.Length-1)&1][^1];
    }
    public int MinPathSum_DFS(int[][] grid) {
        _memo = Enumerable.Range(0,grid.Length).Select(_=>new int[grid[0].Length]).ToArray();
        return MinPathSum(grid, 0, 0);
    }

    int MinPathSum(int[][] grid, int i, int j) {
        if (i == grid.Length - 1 && j == grid[0].Length - 1)
            return grid[i][j];

        if (i >= grid.Length || j >= grid[0].Length)
            return int.MaxValue;

        if (_memo[i][j] > 0)
            return _memo[i][j];
        
        _memo[i][j] = grid[i][j] + Math.Min(MinPathSum(grid, i + 1, j), MinPathSum(grid, i, j + 1));

        return _memo[i][j];
    }
}