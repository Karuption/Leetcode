namespace LeetCode.Medium._2594_Minimum_Time_to_Repair_Cars;

public class Solution {
    public long RepairCars(int[] ranks, int cars) {
        // Set up for binary search across the output space
        var l = (long)ranks.Min();
        var r = (long)(ranks.Max() * Math.Pow(cars, 2));
        var min = r;

        // Binary Search the output space
        while (l <= r) {
            var mid = (l + r) >>> 1;
            if (CanRepairUnder(ranks, mid, cars))
                (min, r) = (mid, mid - 1);
            else
                l = mid + 1;
        }

        return min;
    }

    private static bool CanRepairUnder(int[] ranks, long target, int count) {
        var runningTotal = 0;

        foreach (var rank in ranks) {
            runningTotal += (int)Math.Sqrt(target / (double)rank);
            if (runningTotal >= count)
                return true;
        }

        return false;
    }
}