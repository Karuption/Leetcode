namespace Leetcode.Easy._1137_N_th_Tribonacci_Number;

public class Solution {
    public int Tribonacci(int n) {
        if (n < 1) return 0;
        if (n < 3) return 1;

        int num1 = 2, num2 = 1, num3 = 1;

        for (var i = 0; i < n - 3; i++) (num1, num2, num3) = (num1 + num2 + num3, num1, num2);

        return num1;
    }
}