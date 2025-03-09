namespace LeetCode.Medium._962_Maximum_Width_Ramp; 

public class Solution {
    public int MaxWidthRamp(int[] nums) {
        if (nums.Length < 1)
            return 0;
        
        Stack<int> stack = new();
        stack.Push(0);
        
        // initialize indices that represent a monotonically decreasing stack
        for (int i = 1; i < nums.Length; i++) {
            if (nums[i] < nums[stack.Peek()])
                stack.Push(i);
        }

        int result=0;
        
        for (int j = nums.Length - 1; j >= 0 && stack.Any(); j--) {
            while(stack.Any() && nums[stack.Peek()] <= nums[j])
                result = Math.Max(result, j - stack.Pop());
        }

        return result;
    }
}