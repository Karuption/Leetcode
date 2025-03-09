namespace LeetCode.Medium._45_Jump_Game_II;

public class Solution {
    public int Jump(int[] nums) {
        var maxIndex = 0;
        var currentEnd = maxIndex;
        var jumps = 0;
        
        for (var i = 0; i < nums.Length-1; i++) {
            maxIndex = Math.Max(nums[i] + i, maxIndex);
            
            // reached the furthest I can, have to jump
            // jump to the square that gets me the furthest (max)
            if (i == currentEnd) {
                jumps++;
                currentEnd = maxIndex;
            }
        }
        
        return jumps;
    }
}