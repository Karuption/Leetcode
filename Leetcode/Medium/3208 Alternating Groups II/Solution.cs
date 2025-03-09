namespace LeetCode.Medium._3208_Alternating_Groups_II;

public class Solution {
    // Given input constraints:
    // 3 <= k <= colors.Length
    // 3 <= colors.Length <= 10^5
    // colors[i] is always 0 or 1
    public int NumberOfAlternatingGroups(int[] colors, int k) {
        var total = 0;

        uint count = 1;
        var prev = colors[0];
        for(var i = 1; i < colors.Length + k - 1 ; i++) {

            // if the colors aren't alternating, reset to 0
            if(prev + colors[i%colors.Length] != 1)
                count = 0;
                
            // count the current square
            // if the current sequence is longer than the target, add it to the total
            count++;
            if(count >= k)
                total+=1;
            
            // update previous
            prev = colors[i%colors.Length];
        }

        return total;
    }
}