namespace Leetcode.Medium._128_Longest_Consecutive_Sequence; 

public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums.Length < 1)
            return 0;

        SortedSet<int> set = new(nums);

        int current = 0;
        int longest = 0;
        int previousNum = int.MinValue;
        foreach(var number in set) {
            current = (previousNum+1 == number)?current+1:1;
            longest = Math.Max(longest, current);
            previousNum = number;
        }

        return longest;
    }
}