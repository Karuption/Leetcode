namespace LeetCode.Medium._740_Delete_and_Earn;

public class Solution {
    // Memory optimized, blend counting sort(ish) with robbing houses (medium 213)
    // only allocating O(m) where m is distinct values of n
    // runtime: O(n+(Max(m)-Min(m)));
    public int DeleteAndEarn(ReadOnlySpan<int> nums) {
        SortedDictionary<int, int> dict = new();
        var min = nums[0];
        var max = nums[0];

        for (var i = 0; i < nums.Length; ++i) {
            if (dict.TryGetValue(nums[i], out var temp)) {
                dict[nums[i]] = temp + nums[i];
            }
            else {
                dict.Add(nums[i], nums[i]);
                if (nums[i] > max)
                    max = nums[i];
                else if (nums[i] < min)
                    min = nums[i];
            }
        }

        var num1 = 0;
        var num2 = 0;
        var current = 0;
        for (var i = min; i < max + 1; ++i) {
            if (dict.TryGetValue(i, out var item)) {
                current = Math.Max(item + num1, num2);
                num1 = num2;
                num2 = current;
            }
            else {
                num1 = num2 = Math.Max(num1, num2);
            }
        }

        return current;
    }
}
