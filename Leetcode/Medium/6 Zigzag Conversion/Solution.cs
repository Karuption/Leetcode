using System.Text;

namespace LeetCode.Medium._6_Zigzag_Conversion; 

public class Solution {
    public string Convert(string s, int numRows) {
        if(numRows == 1)
            return s;
            
        List<char>[] lc = Enumerable.Range(0,numRows).Select(_=>new List<char>()).ToArray();
    
        var decending = true;
        int index = 0;
        
        for(int i = 0; i < s.Length; i++) {
            lc[index].Add(s[i]);
                 
            if(index == 0 || index == numRows-1) {
                decending = !decending;
                if(decending)
                    index--;
                else
                    index++;
            } else {
                if(decending)
                    index--;
                else
                    index++;
            }
        }
        
        StringBuilder sb = new();
        foreach(var l in lc) {
            foreach(var c in l) {
                sb.Append(c);
            }
        }

        return sb.ToString();
    }
}