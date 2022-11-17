namespace Leetcode.Medium._223_Rectangle_Area;

public class Solution {
    public int ComputeArea(int ax1, int ay1, int ax2, int ay2, int bx1, int by1, int bx2, int by2) {
        var total = 0;

        var bx = Math.Max(ax1, bx1);
        var by = Math.Max(ay1, by1);
        var tx = Math.Min(ax2, bx2);
        var ty = Math.Min(ay2, by2);

        var isInverted = tx - bx < 0 || ty - by < 0;

        if (!isInverted) total -= Math.Abs((tx - bx) * (ty - by));

        total += Math.Abs((ax2 - ax1) * (ay2 - ay1)) +
                 Math.Abs((bx2 - bx1) * (by2 - by1));

        return total;
    }
}