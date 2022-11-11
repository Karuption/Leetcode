namespace Leetcode.Easy._70_Climbing_Stairs;

public class Solution {
    //climbing with memoization/DP
    private Dictionary<int, int> dict;

    public int ClimbStairs(int n) {
        dict = new Dictionary<int, int>(n);

        dict[1] = 1;
        dict[2] = 2;

        for (var i = 3; i <= n; i++) dict[i] = dict[i - 1] + dict[i - 2];

        return dict[n];
    }
}