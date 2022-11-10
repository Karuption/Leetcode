namespace Leetcode._212_Word_Search_2;

public class Trie {
    private Dictionary<char, Node> _rootNode = new();
    public char EndOfWord { get; init; }

    public Trie(ReadOnlySpan<string> words, char endOfWord) {
        EndOfWord = endOfWord;

        foreach (var word in words)
            Insert(word);
    }
    //A requirement is that words are unique, so no checking if marker is present
    public void Insert(ReadOnlySpan<char> word) {
        var current = _rootNode;

        foreach (var c in word) {
            if (!current.ContainsKey(c))
                current.Add(c, new Node(c));

            current = current[c].Children;
        }
        current.Add(EndOfWord, new(EndOfWord));
    }

    public bool Search(ReadOnlySpan<char> word) {
        var current = _rootNode;

        foreach (var c in word) {
            if (current.TryGetValue(c, out var temp))
                current = temp.Children;
            else
                return false;
        }

        return current.ContainsKey(EndOfWord);
    }

    public bool StartsWith(ReadOnlySpan<char> word) {
        var current = _rootNode;

        foreach (var c in word) {
            if (current.TryGetValue(c, out var temp))
                current = temp.Children;
            else
                return false;
        }

        return true;
    }

    public void Remove(ReadOnlySpan<char> word) {
        var current = _rootNode;
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

        //check if EOW marker is present and return early or remove the marker
        if (!current.ContainsKey(EndOfWord))
            return;
        _ = current.Remove(EndOfWord);

        //remove any nodes that don't have other paths
        var removal = stack.Pop();
        while (stack.Count > 1) {
            if (removal.Children.Count == 0) {
                _ = stack.Peek().Children.Remove(removal.Value);
            }
            removal = stack.Pop();
        }
    }

    public void Remove(IReadOnlyCollection<string> words) {
        foreach (var word in words)
            Remove(word);
    }
}