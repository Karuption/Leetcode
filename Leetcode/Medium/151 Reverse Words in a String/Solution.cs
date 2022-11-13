namespace Leetcode.Medium._151_Reverse_Words_in_a_String;

public class Solution {
    public string ReverseWords(string s) {
        var output = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        for (var i = 0; i < output.Length / 2; ++i)
            (output[i], output[output.Length - i - 1]) = (output[output.Length - i - 1], output[i]);

        return string.Join(' ', output);
    }
}