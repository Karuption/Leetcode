namespace Leetcode.Easy._746_Min_Cost_Climbing_Stairs;

public class Solution {
    public int MinCostClimbingStairs(ReadOnlySpan<int> cost) {
        if (cost.Length < 3) return cost[0] > cost[1] ? cost[0] : cost[1];

        var tCost = 0;
        var current = cost.Length;

        while (current > 1) {
            tCost += cost[current - 1] >= cost[current - 2]
                ? cost[current -= 2]
                : cost[--current];
        }


        return tCost;
    }
}