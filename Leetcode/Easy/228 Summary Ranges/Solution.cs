namespace Leetcode.Easy._228_Summary_Ranges; 

public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        if (nums.Length < 1)
            return Array.Empty<string>();
        
        var start = nums[0];
        List<string> output = new();

        for (var i = 0; i < nums.Length - 1; i++) {
            if(nums[i+1] == nums[i] + 1) continue;
            
            output.Add(start == nums[i] ? start.ToString() : $"{start}->{nums[i]}");
            start = nums[i+1];
        }
        
        output.Add(start == nums[^1] ? start.ToString() : $"{start}->{nums[^1]}");
        
        return output;
    }
}