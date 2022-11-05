using Microsoft.Win32.SafeHandles;

namespace Leetcode._212_Word_Search_2;

public class Trie
{
    private Dictionary<char, Node> _node=new();
    public char EndOfWord { get; init; }

    public Trie() : this('$') { }

    public Trie(char endOfWord) =>
        EndOfWord = endOfWord;

    public Trie(ReadOnlySpan<string> words) : this(words, '$'){}

    public Trie(ReadOnlySpan<string> words, char endOfWord) {
        EndOfWord = endOfWord;

        foreach (var word in words)
            this.Insert(word);
    }

    public void Insert(string word) {
        var markedWord = word + EndOfWord;
        var current = _node;

        foreach (var c in markedWord) {
            if (!current.ContainsKey(c))
                current.Add(c, new Node(c));

            current = current[c].Children;
        }
    }

    public bool Search(string word) {
        var current = _node;

        foreach (var c in word) {
            if (current.ContainsKey(c))
                current = current[c].Children;
            else
                return false;
        }

        return current.ContainsKey(EndOfWord);
    }

    public bool StartsWith(string word) {
        var current = _node;

        foreach (var c in word) {
            if (current.ContainsKey(c)) 
                current = current[c].Children;
            else 
                return false;
        }

        return true;
    }

    public void Remove(string word) {
        var current = _node;
        Stack<Node> stack = new ();

        //finding end of the word and pushing to a stack
        foreach (var c in word) {
            if (current.ContainsKey(c)) {
                stack.Push(current[c]);
                current = current[c].Children;
            }
            else {
                return; //word not found
            }
        }

        //remove EOW marker
        if (!current.ContainsKey(EndOfWord))
            return;
        current.Remove(EndOfWord);

        //remove any parents that don't have other paths
        
    }

    public void Remove(IEnumerable<string> words) {
        foreach (var word in words)
            this.Remove(word);
    }
}