namespace LeetCode.Medium._2390_Removing_Stars_From_a_String;

public class Solution {
    public string RemoveStars(string s) {
        Stack<char> stack = new();

        for (var i = 0; i < s.Length; i++) {
            if (s[i] == '*')
                stack.TryPop(out _);
            else
                stack.Push(s[i]);
        }

        var output = stack.ToArray();
        Array.Reverse(output);

        return new string(output);
    }
}