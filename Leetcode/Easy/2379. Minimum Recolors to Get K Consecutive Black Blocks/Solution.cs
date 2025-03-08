namespace Leetcode.Easy._2379._Minimum_Recolors_to_Get_K_Consecutive_Black_Blocks;

public class Solution {
    public int MinimumRecolors(string blocks, int k) {
        var whiteCount = 0;

        foreach(var c in blocks.AsSpan(0,k)) 
            whiteCount += c is 'W' ? 1 : 0;

        var minWhiteCount = whiteCount;
        for(var i = k; i < blocks.Length && minWhiteCount > 0; i++) {
            whiteCount += blocks[i] is 'W'? 1 : 0;
            whiteCount -= blocks[i-k] is 'W'? 1:0;
            
            minWhiteCount = Math.Min(whiteCount,minWhiteCount);
        }

        return minWhiteCount;
    }
}