namespace Leetcode.Easy._1791._Find_Center_of_Star_Graph;

public class Solution {
    public int FindCenter(int[][] edges) {
        var x = edges[0][0];

        return x == edges[1][0] || x == edges[1][1] ? x : edges[0][1];
    }
}