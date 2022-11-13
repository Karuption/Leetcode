namespace Leetcode.Medium._98_House_Robber;

public class Solution {
    public int Rob(ReadOnlySpan<int> nums) {
        var num1 = 0; // lag variables
        var num2 = 0;
        var current = 0;

        for (var i = 0; i < nums.Length; i++) {
            current = Math.Max(num2, num1 + nums[i]);
            (num1, num2) = (num2, current);
        }

        return current;
    }
}