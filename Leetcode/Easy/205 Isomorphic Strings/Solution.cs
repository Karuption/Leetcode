namespace Leetcode.Easy._205_Isomorphic_Strings; 

public class Solution {
    public bool IsIsomorphic(string s, string t) {
        if(s.Length != t.Length) 
            return false;
        Dictionary<char, char> sDict = new (s.Length);
        HashSet<char> tDict = new (t.Length);

        for(var i = 0; i < s.Length;i++) {
            if(sDict.TryGetValue(s[i], out var tChar)) {
                if(t[i] != tChar)
                    return false;
            } else if(!tDict.Add(t[i])) 
                return false;
            else 
                sDict.Add(s[i], t[i]);
        }

        return true;
    }
}