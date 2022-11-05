namespace Leetcode._212_Word_Search_2;

record Node
{
    public char Value;
    public Dictionary<char,Node> Children;
    public Node(char c) {
        Value=c;
        Children = new Dictionary<char, Node>();
    }
}