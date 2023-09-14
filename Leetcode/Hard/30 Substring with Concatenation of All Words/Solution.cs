namespace Leetcode.Hard._30_Substring_with_Concatenation_of_All_Words; 

public class Solution {
    public IList<int> FindSubstring(string s, string[] words) {
        List<int> output = new();
        SortedDictionary<string, int> dict = new ();
        SortedDictionary<string, int> local = new();

        foreach (var word in words) {
            if (dict.ContainsKey(word)) 
                dict[word]++;
            else {
                dict.Add(word, 1);
                local.Add(word,0);
            }
        }
        
        var wordLength = words[0].Length;
        var start = 0;

        for (int j = 0; j < wordLength; j++) {
            start = j;
            for (var i = j; i + wordLength <= s.Length;i += wordLength) {
                var sWord = s.Substring(i, wordLength);
                if (dict.TryGetValue(sWord, out var count)) {
                    local[sWord]++;
                    while (count < local[sWord] && start+wordLength <= i) {
                        var startWord = s.Substring(start, wordLength);
                        if(local.ContainsKey(startWord))
                            local[startWord]--;
                        start += wordLength;
                    }
                } else {
                    while (start < i) {
                        var startWord = s.Substring(start, wordLength);
                        if(local.ContainsKey(startWord))
                            local[startWord]--;
                        start += wordLength;
                    }

                    start += wordLength;
                    continue;
                }
                if (dict.SequenceEqual(local)) {
                    output.Add(start);
                    var startWord = s.Substring(start, wordLength);
                    if(local.ContainsKey(startWord))
                       local[startWord]--;
                    start += wordLength;
                }
            }
        
            if(dict.SequenceEqual(local))
                output.Add(start);
            
            foreach (var key in dict.Keys)
                local[key] = 0;
        }
        
        return output;
    }
}