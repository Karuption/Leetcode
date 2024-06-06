namespace Leetcode.Easy._1002._Find_Common_Characters;

public class Solution {
    public IList<string> CommonChars(string[] words) {
        Span<byte> total = stackalloc byte[26] {byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue};
        Span<byte> current = stackalloc byte[26];

        foreach (var word in words) {
            current.Clear();
            foreach (var c in word)
                current[c-'a']++;

            for (var i = 0; i < total.Length; i++) 
                total[i] = Math.Min(total[i], current[i]);
        }

        var output = new List<string>();
        for (var i = 0; i < 26; i++) {
            var value = total[i];
            if(value == 0)
                continue;
            
            var letter = new string((char)(i + 'a'), 1);
            for(var j = 0; j < value; j++)
                output.Add(letter);
        }

        return output;
    }
}