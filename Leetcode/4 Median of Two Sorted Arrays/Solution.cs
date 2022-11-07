namespace Leetcode._4_Median_of_Two_Sorted_Arrays;

public class Solution {
    public double FindMedianSortedArrays(double[] nums1, double[] nums2) {
        var leftTarget = (nums1.Length + nums2.Length) / 2;
        var averagingRequired = (nums1.Length + nums2.Length) % 2 == 0 ? true : false;

        var i = 0;
        var j = 0;

        var l = 0; //always get the next number, then decide if its needed in the return
        var r = 0;

        while (i + j <= leftTarget) {
            //figure out the min and move the corrisponding pointer
            //while staying in array bounds
        }

        return averagingRequired ? (l + r) / 2d : l;
    }
}
