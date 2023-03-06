namespace Leetcode.Easy._1539_Kth_Missing_Positive_Number; 

public class Solution {
    // Find the kth positive integer that is missing from this array.
    // Constraint: 1<=k
    // Constraint: 1<=arr[i]<=1000
    
    //straight forward solution
    // public int FindKthPositive(ReadOnlySpan<int> arr, int k) {
    //     int current = 0;
    //     int missing = 0;
    //
    //     foreach (var val in arr) {
    //         while (val > ++current) {
    //             if (k == ++missing)
    //                 return current;
    //         }
    //     }
    //
    //     return current + (k - missing);
    // }
    
    public int FindKthPositive(ReadOnlySpan<int> arr, int k) {
        if(k>arr[^1]-arr.Length) 
            return k + arr.Length;
        
        int left = 0;
        int right = arr.Length - 1;
        
        while (left <= right) {
            int mid = left + ((right - left) >> 2);
            if (arr[mid] - (mid + 1) < k) 
                left = mid+1;
            else
                right = mid-1;
            
        }

        return k  + left;
    }
}