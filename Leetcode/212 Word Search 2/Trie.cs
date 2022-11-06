using Microsoft.Win32.SafeHandles;

namespace Leetcode._212_Word_Search_2;

public class Trie {
    private Dictionary<char, Node> _node = new();
    public char EndOfWord { get; init; }

    public Trie(ReadOnlySpan<string> words, char endOfWord) {
        EndOfWord = endOfWord;

        foreach (var word in words)
            this.Insert(word);
    }

    public void Insert(string word) {
        ReadOnlySpan<char> markedWord = word + EndOfWord;
        var current = _node;

        foreach (var c in markedWord) {
            if (!current.ContainsKey(c))
                current.Add(c, new Node(c));

            current = current[c].Children;
        }
    }

    public bool Search(ReadOnlySpan<char> word) {
        var current = _node;

        foreach (var c in word) {
            if (current.TryGetValue(c, out var temp))
                current = temp.Children;
            else
                return false;
        }

        return current.ContainsKey(EndOfWord);
    }

    public bool StartsWith(ReadOnlySpan<char> word) {
        var current = _node;
        Node? temp;

        foreach (var c in word) {
            if (current.TryGetValue(c, out temp))
                current = temp.Children;
            else
                return false;
        }

        return true;
    }

    public void Remove(ReadOnlySpan<char> word) {
        var current = _node;
        Stack<Node> stack = new();

        //finding end of the word and pushing to a stack
        foreach (var c in word) {
            if (current.TryGetValue(c, out var temp)) {
                stack.Push(temp);
                current = temp.Children;
            } else {
                return; //word not found
            }
        }

        //remove EOW marker
        if (!current.ContainsKey(EndOfWord))
            return;
        current.Remove(EndOfWord);

        //remove any parents that don't have other paths
        Node removal=stack.Pop();
        while (stack.Count > 0) {
            if (removal.Children.Count == 0) {
                stack.Peek().Children.Remove(removal.Value);
            }
            removal=stack.Pop();
        }
    }

    public void Remove(IReadOnlyCollection<string> words) {
        foreach (var word in words)
            this.Remove(word);
    }
}