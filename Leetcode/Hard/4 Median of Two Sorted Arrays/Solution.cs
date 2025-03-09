namespace LeetCode.Hard._4_Median_of_Two_Sorted_Arrays;

public class Solution {
    PriorityQueue<int, int> left = new();
    PriorityQueue<int, int> right = new();
    
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int l = 0;
        int r = 0;

        //pick the next correct number until one list is exhausted
        while (l < nums1.Length && r < nums2.Length) {
            if (nums1[l] > nums2[r]) 
                queueAdd(nums1[l++]);
            else
                queueAdd(nums2[r++]);
        }

        //add whatever list is not exhausted
        while (r < nums2.Length)
            queueAdd(nums2[r++]);
        
        while (l < nums1.Length)
            queueAdd(nums1[l++]);

        //return logic: if they are equal, we need to average
        //otherwise, take the top of the one that has more items
        if (left.Count > right.Count)
            return left.Dequeue();

        if (right.Count > left.Count)
            return right.Dequeue();

        return (left.Dequeue() + right.Dequeue()) / 2d;
    }

    private void queueAdd(int item) {
        if (left.Count==0 || item < left.Peek())
            left.Enqueue(item, -item);
        else
            right.Enqueue(item, item);

        ballance();
    }

    private void ballance() {
        if(left.Count > right.Count+1) {
            right.Enqueue(left.Peek(), left.Dequeue());
            return;
        }

        if(right.Count > left.Count+1)
            left.Enqueue(right.Peek(),-right.Dequeue());
    }
}
