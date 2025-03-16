namespace LeetCode.Medium._2560_House_Robber_IV;

public class Solution {
    
    public int MinCapability(int[] nums, int k) {
        var (l, r) = FindLimits(nums);

        int last = 0;
        while( l <= r) {
            var mid = (l+r) >>> 1;
            if(Scan(nums, mid, k)) {
                r = mid-1;
                last = mid;
            } else {
                l = mid + 1;
            }
        }

        return last;
    }

    public (int, int) FindLimits(int[] nums) {
        int min = nums[0];
        int max = min;

        foreach(var h in nums) 
            (min, max) = (Math.Min(h, min), Math.Max(h, max));

        return (min, max);
    }

    public bool Scan(int[] nums, int value, int minCount) {
        int count = 0;
        for(int i = 0; i < nums.Length; i++) {
            if(nums[i] > value)
                continue;

            if(++count == minCount)
                return true;
            i++;
        }

        return false;
    }
}