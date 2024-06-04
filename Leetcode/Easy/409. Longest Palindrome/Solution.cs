namespace Leetcode.Easy._409._Longest_Palindrome;

public class Solution {
    public int LongestPalindrome(string s) {
        Span<int> chars = stackalloc int[26*2];

        foreach(var c in s) 
            chars[(c%52)]++;

        int odds = 0;
        int evens = 0;
        foreach(var c in chars) {
            evens += c & 0xFF_FE;
            odds = (c & 1) | odds;
        }

        return evens + odds;
    }
}