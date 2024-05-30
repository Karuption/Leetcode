namespace Leetcode.Medium._1404._Number_of_Steps_to_Reduce_a_Number_in_Binary_Representation_to_One;

public class Solution {
    public int NumSteps(string s) {
        var steps = 0;
        var carry = 0;
        
        for (var i = s.Length - 1; i > 0; i--) {
            var current = s[i] - '0';

            if (current != carry) 
                steps += carry = 1;

            steps++;
        }

        // Since s cannot equal 0
        return steps + carry;
    }
}