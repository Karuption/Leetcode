namespace LeetCode.Easy._2206_Divide_Array_Into_Equal_Pairs;

public class Solution {
    public bool DivideArray(int[] nums) {
        Span<int> span = stackalloc int[501];
        var runningCount = 0;

        foreach (var num in nums) {
            span[num] ^= 1;
            runningCount += (span[num] << 1) - 1;
        }

        return runningCount == 0;
    }
}