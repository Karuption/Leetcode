namespace Leetcode.Hard._4_Median_of_Two_Sorted_Arrays;

public class Solution {
    public double FindMedianSortedArrays(double[] nums1, double[] nums2) {
        var leftMostTarget = (nums1.Length + nums2.Length + 1) / 2;
        var averagingRequired = (nums1.Length + nums2.Length) % 2 == 0 ? true : false;

        var i = 0;
        var j = 0;
        var totalCount = 0;

        double l = 0;

        while (i < nums1.Length && j < nums2.Length) {
            //figure out the min and move the corrisponding pointer
            //while staying in array bounds
            totalCount++;
            if (nums1[i] < nums2[j]) {
                if (totalCount == leftMostTarget) {
                    l = nums1[i];
                    if (!averagingRequired)
                        return l;
                }
                else if (totalCount == leftMostTarget + 1) {
                    return (l + nums1[i]) / 2;
                }

                i++;
            }
            else {
                if (totalCount == leftMostTarget) {
                    l = nums2[j];
                    if (!averagingRequired)
                        return l;
                }
                else if (totalCount == leftMostTarget + 1) {
                    return (l + nums2[j]) / 2;
                }

                j++;
            }
        }

        if (i == nums1.Length) {
            if (totalCount == leftMostTarget) //if we already got l
                return averagingRequired ? (l + nums2[leftMostTarget - totalCount]) / 2 : nums2[totalCount];

            return averagingRequired
                ? (nums2[leftMostTarget - totalCount - 1] + nums2[leftMostTarget - totalCount]) / 2
                : nums2[leftMostTarget - totalCount - 1];
        }

        if (totalCount == leftMostTarget)
            return averagingRequired
                ? (l + nums1[leftMostTarget - totalCount]) / 2
                : nums1[leftMostTarget - totalCount - 1];

        return averagingRequired
            ? (nums1[leftMostTarget - totalCount - 1] + nums1[leftMostTarget - totalCount]) / 2
            : nums1[leftMostTarget - totalCount - 1];
    }
}
