namespace Leetcode.Medium._223_Rectangle_Area;

public class Solution {
    public int ComputeArea(int ax1, int ay1, int ax2, int ay2, int bx1, int by1, int bx2, int by2) {
        var bx = Math.Max(ax1, bx1);
        var by = Math.Max(ay1, by1);
        var tx = Math.Min(ax2, bx2);
        var ty = Math.Min(ay2, by2);

        int total = (ax2 - ax1) * (ay2 - ay1) +
                    (bx2 - bx1) * (by2 - by1);

        if (tx > bx && ty > by) {
            return total - (tx - bx) * (ty - by);
        }
        return total;
    }
}