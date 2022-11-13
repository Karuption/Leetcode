namespace Leetcode.Medium._98_House_Robber;

public class Solution {
    private Dictionary<int, int> dict;

    public int Rob(ReadOnlySpan<int> nums) {
        //dict = new(nums.Length);
        int[] cost = { 0, 0 };

        for (var i = 0; i < nums.Length; i++) cost[i % 2] += nums[i];

        return Math.Max(cost[0], cost[1]);
    }
}