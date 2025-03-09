namespace LeetCode.Easy._1704_Detirmine_if_String_halfs_are_alike;

public class Solution {
    //Could improve by doing the left and right half at the same time. 
    //That would reduce stack variable instantiation/stack overhead
    //Instead of a switch statement, could use a hashset and check if key is already present
    public bool HalvesAreAlike(ReadOnlySpan<char> s) {
        return CountVowels(s, 0, s.Length / 2) == CountVowels(s, s.Length / 2, s.Length / 2);
    }

    private static int CountVowels(ReadOnlySpan<char> s, int start, int length) {
        if (s.Length < start + length)
            throw new ArgumentOutOfRangeException();

        var count = 0;
        for (var i = 0; i < length; i++) {
            count = char.ToLower(s[i + start]) switch {
                'a' => count + 1,
                'e' => count + 1,
                'i' => count + 1,
                'o' => count + 1,
                'u' => count + 1,
                _ => count
            };
        }

        return count;
    }
}