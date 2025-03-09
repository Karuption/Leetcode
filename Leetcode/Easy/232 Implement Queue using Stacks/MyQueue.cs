namespace LeetCode.Easy._232_Implement_Queue_using_Stacks;

public class MyQueue {
    private readonly Stack<int> s = new();
    private readonly Stack<int> s2 = new();

    public void Push(int x) {
        while (!s.Empty()) s2.Push(s.Pop());
        s.Push(x);
        while (!s2.Empty()) s.Push(s2.Pop());
    }

    public int Pop() {
        return s.Pop();
    }

    public int Peek() {
        return s.Peek();
    }

    public bool Empty() {
        return s.Empty();
    }
}

public static class Extensions {
    public static bool Empty<T>(this Stack<T> stack) {
        return stack.Count == 0;
    }
}