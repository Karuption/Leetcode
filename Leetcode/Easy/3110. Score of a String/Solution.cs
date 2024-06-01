namespace Leetcode.Easy._3110._Score_of_a_String;

public class Solution {
    // Linq/Functional Solution
    // public int ScoreOfString(string s) {
    //     return s.Aggregate((Last: s[0], Score: 0), 
    //             (total, current) => (current,Math.Abs(total.Last - current) + total.Score))
    //         .Score;
    // }
    
    public int ScoreOfString(string s) {
        var score = 0;

        for (int i = 1; i < s.Length; i++) {
            score += Math.Abs(s[i-1] - s[i]);
        }
        
        return score;
    }
}