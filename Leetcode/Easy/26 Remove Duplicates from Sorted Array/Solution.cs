namespace LeetCode.Easy._26_Remove_Duplicates_from_Sorted_Array;

public class Solution {
    public int RemoveDuplicates(int[] nums) {
        var fast = 1;
        var slow = 0;
        var count = 1;

        while (fast < nums.Length) {
            if (nums[slow] != nums[fast]) {
                count++;
                nums[++slow] = nums[fast];
            }

            fast++;
        }

        return nums[fast - 1] != nums[slow] ? count + 1 : count;
    }
}