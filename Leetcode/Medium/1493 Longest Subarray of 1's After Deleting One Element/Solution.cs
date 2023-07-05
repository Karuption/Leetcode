namespace Leetcode.Medium._1493_Longest_Subarray_of_1_s_After_Deleting_One_Element; 

public class Solution {
    public int LongestSubarray(int[] nums) {
        var start = nums.Length+1;
        var del = nums.Length+1;
        var end = -2;
        var max = 0;

        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] == 1) {
                // if start is unset
                if (start > end) 
                    start = end = i;
                else 
                    end = i;
                max = Math.Max(end - start + ((del > nums.Length)?1:0), max);
                continue;
            }
            
            // if 0 and del is not set, set del
            if (del > nums.Length && start < nums.Length)
                del = i;
            
            // if del is set and the next value in the sequence is 1, set del to i 
            else if (del < nums.Length && nums[del + 1] == 1) {
                start = del + 1;
                del = i;
            } else {
                start = del = nums.Length+1;
                end = -1;
            }
        }

        // if there are only ones, delete an element
        return (max == nums.Length && del > nums.Length) 
            ? max-1
            : max;
    }
}