namespace Leetcode.Easy._35_Search_Insert_Position;

public class Solution {
    public int SearchInsert(int[] nums, int target) {
        var left = 0;
        var right = nums.Length;
        int mid;
        while (left < right) {
            mid = left + (right - left) / 2;
            if (nums[mid] == target)
                return mid;
            if (nums[mid] > target)
                right = mid;
            else
                left = mid + 1;
        }

        return right;
    }
}