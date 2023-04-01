namespace Leetcode.Easy._704_Binary_Search;

public class Solution {
    public int Search(ReadOnlySpan<int> nums, int target) {
        var l = 0;
        var r = nums.Length - 1;

        while (l <= r) {
            var mid = l + (r - l) / 2;

            if (nums[mid] == target)
                return mid;

            if (nums[mid] > target)
                r = mid - 1;
            else if (nums[mid] < target)
                l = mid + 1;
        }

        return -1;
    }
}