namespace Leetcode.Medium._120_Triangle; 

public class Solution {
    private int[][] _memo;
    public int MinimumTotal(IList<IList<int>> triangle) {
        _memo = Enumerable.Range(0, triangle.Count).Select((_,i) => Enumerable.Repeat(int.MaxValue, i+1).ToArray()).ToArray();
        return MinimumTotal_DFS(triangle, 0, 0);
    }

    private int MinimumTotal_DFS(IList<IList<int>> triangle, int level, int i) {
        if (_memo[level][i] < int.MaxValue)
            return _memo[level][i];
        
        var sum = triangle[level][i];
        
        if(level+1<triangle.Count)
            sum += Math.Min(MinimumTotal_DFS(triangle, level + 1,i), 
                   MinimumTotal_DFS(triangle, level + 1, i + 1));

        _memo[level][i] = sum;
        return sum;
    }
}