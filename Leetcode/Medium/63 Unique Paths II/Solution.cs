namespace Leetcode.Medium._63_Unique_Paths_II; 

public class Solution {
    private int[][] _memo;
    public int UniquePathsWithObstacles(int[][] obstacleGrid) {
        // guard against an impossible path (block at the start or end)
        if (obstacleGrid[^1][^1] == 1 || obstacleGrid[0][0] == 1)
            return 0;
        
        //
        if(obstacleGrid.Length == 1 || obstacleGrid[0].Length == 1){
            return obstacleGrid.SelectMany(x => x).Sum() > 0? 0: 1;
        }
            
        _memo = Enumerable.Range(0, 2)
                          .Select(_=>Enumerable.Repeat(1, obstacleGrid[0].Length).ToArray())
                          .ToArray();

        for (int i = 1; i < _memo.Length; i++) 
            for (int j = 1; j < _memo[0].Length; j++) 
                _memo[i&1][j] = obstacleGrid[i-1][j]==0?_memo[(i - 1)&1][j]:0 
                    + obstacleGrid[i-1][j]==0?_memo[i&1][j - 1]:0;

        return _memo[(_memo.Length-1)&1][^1]+1;
    }
    
    public int UniquePathsWithObstacles_DFS(int[][] obstacleGrid) {
        if (obstacleGrid[^1][^1] == 1 || obstacleGrid[0][0] == 1)
            return 0;
        _memo = Enumerable.Range(0, obstacleGrid.Length)
                          .Select(_=>Enumerable.Repeat(-1, obstacleGrid[0].Length).ToArray())
                          .ToArray();
        return UniquePathsWithObstacles_DFS(obstacleGrid, 0, 0);
    }

    private int UniquePathsWithObstacles_DFS(int[][] obstacleGrid, int x, int y) {
        if (x == obstacleGrid.Length - 1 && y == obstacleGrid[0].Length - 1)
            return 1;

        if (!(x<obstacleGrid.Length) || !(y<obstacleGrid[0].Length) || !(obstacleGrid[x][y] == 0))
            return 0;

        if (_memo[x][y] > -1)
            return _memo[x][y];

        _memo[x][y] = UniquePathsWithObstacles_DFS(obstacleGrid, x + 1, y) + 
            UniquePathsWithObstacles_DFS(obstacleGrid, x, y + 1);

        return _memo[x][y];
    }
}