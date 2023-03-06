namespace Leetcode.Easy._1539_Kth_Missing_Positive_Number; 

public class Solution {
    // Find the kth positive integer that is missing from this array.
    // Constraint: 1<=k
    // Constraint: 1<=arr[i]<=1000
    public int FindKthPositive(ReadOnlySpan<int> arr, int k) {
        int current = 0;
        int missing = 0;

        foreach (var val in arr) {
            while (val > ++current) {
                if (k == ++missing)
                    return current;
            }
        }

        return current + (k - missing);
    }
}