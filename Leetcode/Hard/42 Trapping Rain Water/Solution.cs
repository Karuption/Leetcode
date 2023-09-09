using System.Diagnostics;

namespace Leetcode.Hard._42_Trapping_Rain_Water; 

public class Solution {
    public int Trap(int[] height) {
        int l = 0, r = height.Length - 1;
        int lMax = 0, rMax = 0;
        int water = 0;

        while (l <= r) {
            if (height[l] >= lMax) 
                lMax = height[l++];
            else if(height[r] >= rMax)
                rMax = height[r--];
            else if(lMax <= rMax) 
                water += lMax - height[l++];
            else 
                water += rMax - height[r--];
        }
        
        return water;
    }
}