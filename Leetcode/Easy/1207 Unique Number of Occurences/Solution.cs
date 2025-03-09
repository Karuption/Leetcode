namespace LeetCode.Easy._1207_Unique_Number_of_Occurences;

public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        Dictionary<int, int> Occurences = new();

        for (var i = 0; i < arr.Length; i++) {
            if (Occurences.TryGetValue(arr[i], out var temp))
                Occurences[arr[i]]++;
            else
                Occurences[arr[i]] = 1;
        }

        HashSet<int> set = new();

        foreach (var k in Occurences.Keys) {
            if (set.Contains(Occurences[k]))
                return false;
            set.Add(Occurences[k]);
        }

        return true;
    }
}