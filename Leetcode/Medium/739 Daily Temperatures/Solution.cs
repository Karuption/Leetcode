namespace Leetcode.Medium._739_Daily_Temperatures;

public class Solution {
    private int[] output;

    public int[] DailyTemperatures(int[] temperatures) {
        Stack<(int, int)> stack = new(temperatures.Length);
        output = new int[temperatures.Length];

        for (var i = 0; i < temperatures.Length; i++) {
            while (stack.TryPeek(out var res) && res.Item1 < temperatures[i])
                output[res.Item2] = i - stack.Pop().Item2;

            stack.Push((temperatures[i], i));
        }

        return output;
    }
}