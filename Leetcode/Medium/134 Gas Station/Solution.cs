namespace LeetCode.Medium._134_Gas_Station; 

public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        var runningSum = 0;
        var startIndex = 0;
        var current = 0;
        
        for(var i = 0; i < gas.Length; i++) {
            current += gas[i] - cost[i];
            runningSum += gas[i]-cost[i];
            
            if (current < 0) {
                startIndex = i+1;
                current = 0;
            }
        }

        return runningSum >= 0? startIndex : -1;
    }
}