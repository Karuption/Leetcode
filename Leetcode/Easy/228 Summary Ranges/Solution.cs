namespace Leetcode.Easy._228_Summary_Ranges; 

public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        if(nums.Length < 1)
            return new List<string>();

        int lastValue = nums[0];
        int start = nums[0];
        List<string> output = new();


        for(int i = 1; i < nums.Length; i++) {
            if(nums[i] != lastValue + 1) {
                if(start == lastValue)
                    output.Add(lastValue.ToString());
                else
                    output.Add($"{start}->{lastValue}");

                start = nums[i];
            }

            lastValue = nums[i];
        }

        if(start == lastValue)
            output.Add(lastValue.ToString());
        else
            output.Add($"{start}->{lastValue}");

        return output;
    }
}