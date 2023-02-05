namespace Leetcode.Medium._438_Find_All_Anagrams_in_a_String;

public class Solution {
    public IList<int> FindAnagrams(string s, string p) {
        List<int> anagramStart = new();

        if (s.Length < p.Length)
            return anagramStart;

        var pValues = new int[26];
        var currentValues = new int[26];

        for (var i = 0; i < p.Length; i++) {
            pValues[p[i] - 'a']++;
            currentValues[s[i] - 'a']++;
        }

        if (currentValues.SequenceEqual(pValues))
            anagramStart.Add(0);

        for (var i = p.Length; i < s.Length; i++) {
            currentValues[s[i - p.Length] - 'a']--;
            currentValues[s[i] - 'a']++;

            if (currentValues.SequenceEqual(pValues))
                anagramStart.Add(i - p.Length + 1);
        }

        return anagramStart;
    }
}