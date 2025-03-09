namespace LeetCode.Medium._1647_Minimum_Deletions_to_Make_Character_Frequencies_Unique; 

public class Solution {
    public int MinDeletions(string s) {
        Span<int> freq = stackalloc int[26];

        foreach(var c in s)
            freq[c-'a']++;

        int alterations= 0;
        HashSet<int> set = new(26);
        for(int i = 0; i < freq.Length; i++) {
            while(!set.Add(freq[i]) && freq[i] != 0) {
                freq[i]--;
                alterations++;
            }
        }

        return alterations;
    }
}