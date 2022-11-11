using System.Text;

namespace Leetcode.Easy._1047_Remove_All_Adjacent_Duplicates_In_String;

public class Solution {
    //beats 86.73% in runtime
    //beats 88.63% in memory
    //public string RemoveDuplicates(ReadOnlySpan<char> s) {
    //    Stack<char> stack = new();


    //    for (var i = 0; i < s.Length; i++) {
    //        if (stack.Count == 0 || !s[i].Equals(stack.Peek()))
    //            stack.Push(s[i]);
    //        else
    //            stack.Pop();
    //    }

    //    return new string(stack.Reverse().ToArray());
    //}

    //beats 81.52% in runtime
    //beats 88.63% in memory
    public string RemoveDuplicates(ReadOnlySpan<char> s) {
        StringBuilder sb = new(s.Length);


        for (var i = 0; i < s.Length; i++) {
            if (sb.Length == 0 || !s[i].Equals(sb[sb.Length - 1]))
                sb.Append(s[i]);
            else
                sb.Remove(sb.Length - 1, 1);
        }

        return sb.ToString();
    }
}

