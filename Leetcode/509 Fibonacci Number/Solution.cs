namespace Leetcode._509_Fibonacci_Number;

public class Solution {
    //using DP
    public int Fib(int n) {
        if (n < 1) return 0;
        if (n < 3) return 1;
        int num1 = 1, num2 = 1;

        for (var i = 0; i < n - 2; i++) (num1, num2) = (num1 + num2, num1);

        return num1;
    }
}