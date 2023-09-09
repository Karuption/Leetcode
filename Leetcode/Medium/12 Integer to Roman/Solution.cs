using System.Text;

namespace Leetcode.Medium._12_Integer_to_Roman; 

public class Solution {
    public string IntToRoman(int num) {
        StringBuilder sb = new();
        ReadOnlySpan<string> numerals = new string[] {"M","CM","D","CD","C","XC","L","XL","X","IX","V","IV","I"};
        ReadOnlySpan<int> values = stackalloc int[] {1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1};
        for(var i = 0; i<numerals.Length; i++) {
            while(num >= values[i]) { 
                sb.Append(numerals[i]);
                num-=values[i];
            }
        }

        return sb.ToString();
    }
}