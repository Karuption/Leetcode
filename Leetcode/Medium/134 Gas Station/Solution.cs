namespace Leetcode.Medium._134_Gas_Station; 

public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        for(var i = 0; i < gas.Length; i++) {
            var gasAmount = gas[i] - cost[i];
            if(gasAmount<0){
                continue;
            }

            for(var j = (i+1)%gas.Length; j != i; j=(j+1)%gas.Length) {
                gasAmount += gas[j];
                gasAmount -= cost[j];
                if(gasAmount < 0)
                    break;
            }

            if(gasAmount >= 0)
                return i;
        }

        return -1;
    }
}