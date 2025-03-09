namespace LeetCode.Medium._213_House_Robber_2;

public class Solution {
    public int Rob(int[] nums) {
        if (nums.Length < 4) return nums.Max();

        var num1l = 0;
        var num1r = 0;
        var num2r = 0;
        var num2l = 0;
        var currentl = 0;
        var currentr = 0;

        for (var i = 1; i < nums.Length; i++) {
            currentr = Math.Max(num2r, nums[i] + num1r);
            (num1r, num2r) = (num2r, currentr);

            currentl = Math.Max(num2l, nums[i - 1] + num1l);
            (num1l, num2l) = (num2l, currentl);
        }

        return Math.Max(currentl, currentr);
    }
}