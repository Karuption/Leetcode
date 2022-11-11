namespace Leetcode.Medium._901_Online_Stock_Span;

/**
 * Your StockSpanner object will be instantiated and called as such:
 * StockSpanner obj = new StockSpanner();
 * int param_1 = obj.Next(price);
 */
public class StockSpanner {
    private readonly Stack<KeyValuePair<int, int>> stack = new(); //price, previousStreak

    public int Next(int price) {
        var previousLessThan = 1; //since we include itself in the value

        //While there is an entry that is less than the current entry, pop the stack
        //when we pop the stack, take the value (previous streak) and add to the current streak.
        while (stack.Count > 0 && price >= stack.Peek().Key) previousLessThan += stack.Pop().Value;

        stack.Push(new KeyValuePair<int, int>(price, previousLessThan));

        return previousLessThan;
    }
}
