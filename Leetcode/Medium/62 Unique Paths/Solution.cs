using System.Runtime.CompilerServices;

namespace Leetcode.Medium._62_Unique_Paths; 

public class Solution {
    // number of unique routes
    // constraints: 1 <= m, n<= 100
    // m x n matrix. Only can go right and below
    // starts at [0,0] ends at [m-1,n-1]
    private int[][] _memo;
    public int UniquePaths(int m, int n) {
        int[][] memo = Enumerable.Range(0,2).Select(x=>Enumerable.Range(0,n).Select(x=>1).ToArray()).ToArray();
        
        for (int i = 1; i < m; i++) 
            for (int j = 1; j < memo[0].Length; j++) 
                memo[i&1][j] = memo[i&1][j-1] + memo[(i-1)&1][j];

        return memo[(m - 1)&1][n - 1];
    }
    
    public int UniquePaths_dfs(int m, int n) {
        _memo = Enumerable.Range(0,m).Select(x=>Enumerable.Range(0,n).Select(x=>-1).ToArray()).ToArray();
        int finishx = m - 1;
        int finishy = n - 1;
        return dfs_UniquePaths(0, 0,in finishx,in finishy);
    }

    private int dfs_UniquePaths(int m, int n, in int fm, in int fn) {
        //recursion base case
        if (m == fm && n == fn)
            return 1;
        
        //bound box
        if (m > fm || n > fn)
            return 0;
        
        //if we have been there before, return the cached value
        if (-1 < _memo[m][n])
            return _memo[m][n];
        
        //save right then down counts to cache
        _memo[m][n] = dfs_UniquePaths(m + 1, n, in fm, in fn) + 
               dfs_UniquePaths(m, n + 1, in fm, in fn);

        return _memo[m][n];
    }
}