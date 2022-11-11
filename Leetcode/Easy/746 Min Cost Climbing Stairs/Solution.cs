namespace Leetcode.Easy._746_Min_Cost_Climbing_Stairs;

public class Solution {
    //memoized
    //public int MinCostClimbingStairs(ReadOnlySpan<int> cost) {
    //    if (cost.Length < 2) return cost[0];
    //    if (cost.Length < 3) return Math.Min(cost[0], cost[1]);


    //    Dictionary<int, int> dict = new(cost.Length);

    //    dict[0] = cost[0];
    //    dict[1] = cost[1];

    //    for (var i = 2; i < cost.Length; i++) dict[i] = cost[i] + Math.Min(dict[i - 1], dict[i - 2]);

    //    return Math.Min(dict[cost.Length - 1], dict[cost.Length - 2]);
    //}

    public int MinCostClimbingStairs(ReadOnlySpan<int> cost) {
        if (cost.Length < 2) return cost[0];

        var num1 = cost[0];
        var num2 = cost[1];
        var current = 0;

        for (var i = 2; i < cost.Length; i++) {
            current = cost[i] + Math.Min(num1, num2);
            (num1, num2) = (num2, current);
        }

        return Math.Min(num1, num2);
    }
}