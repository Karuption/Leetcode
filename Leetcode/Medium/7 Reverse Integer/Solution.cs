namespace LeetCode.Medium._7_Reverse_Integer; 

public class Solution {
    public int Reverse(int x) {
        var rev = 0;

        try {
            var absx = Math.Abs(x);
            checked {
                while(absx > 0) {
                    rev = (rev*10) + absx%10;
                    absx /= 10;
                }
                rev *= Math.Sign(x);
            }
        } catch {
            return 0;
        }

        return rev;
    }
}