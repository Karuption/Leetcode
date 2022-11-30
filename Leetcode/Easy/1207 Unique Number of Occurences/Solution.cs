namespace Leetcode.Easy._1207_Unique_Number_of_Occurences;

public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        Dictionary<int, int> Occurences = new();

        for (var i = 0; i < arr.Length; i++) {
            if (Occurences.TryGetValue(arr[i], out var temp))
                Occurences[arr[i]]++;
            else
                Occurences[arr[i]] = 1;
        }

        return Occurences.Values.Count == Occurences.Values.Distinct().Count();
    }
}