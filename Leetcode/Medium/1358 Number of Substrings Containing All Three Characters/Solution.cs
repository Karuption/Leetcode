namespace LeetCode.Medium._1358_Number_of_Substrings_Containing_All_Three_Characters;

public class Solution {
    // s always only contains a, b, or c
    // 3 <= s.Length <= 5 * 10^4
    public int NumberOfSubstrings(string s) {
        // use 0(1) space for lookups
        // avoid hash functions since sequential chars can be indexes with subtraction
        Span<int> letterCount = [0,0,0];
        var total = 0;

        // sliding window with first index initialization
        // could be converted to single index with foreach, but is less clear
        var r = 0;
        letterCount[s[0]-'a'] = 1;
        for(var l = 0; l < s.Length; l++) {
            while(r < s.Length-1) {
                if (Math.Min(letterCount[0], Math.Min(letterCount[1], letterCount[2])) < 1)
                    letterCount[s[++r] - 'a']++;
                else
                    break;
            }
            
            // Check if r is at the end of the string and doesn't match the requirements
            if(r == s.Length - 1 && Math.Min(letterCount[0], Math.Min(letterCount[1], letterCount[2])) < 1)
                break;

            // Get the number of chars remaining (counting the current index)
            // Including anything to the right of the match would count as a matching substring
            total += s.Length - r;
            
            // Remove the leftmost value from the window and slide
            letterCount[s[l]-'a']--;
        }

        return total;
    }
}