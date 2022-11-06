using Leetcode._212_Word_Search_2;

namespace LeetCodeTests._212_Word_Search_2;
public class TrieTests {
    [Fact]
    public void Insert_ShouldFindWordAndPrefix() {
        Trie t = new(new[] { "hello", "helno" },'$');

        Assert.Equal(t.Search("hello"), true);
        Assert.Equal(t.Search("helno"), true);
        Assert.Equal(t.StartsWith("heln"), true);
        Assert.Equal(t.StartsWith("hell"), true);

        Assert.Equal(t.StartsWith("on"), false);
    }

    [Fact]
    public void Remave_ShouldRemoveAsManyNodesAsPossible() {
        Trie t = new(new[] { "hello", "helno" }, '$');

        t.Remove("helno");

        Assert.Equal(false, t.StartsWith("heln")); 
        Assert.Equal(false, t.Search("helno")); 
        Assert.Equal(true, t.Search("hello"));
    }

    [Fact]
    public void MultipleRemoval_ShouldRemoveAsManyNodesAsPossible() {
        Trie t = new(new[] { "hello", "hella", "helno", "help" }, '$');

        t.Remove(new []{"hello","hella", "helno"});

        Assert.Equal(false, t.Search("heln")); 
        Assert.Equal(false, t.Search("hell"));
        Assert.Equal(false, t.Search("helno"));
        Assert.Equal(false, t.Search("hel"));
        Assert.Equal(false, t.StartsWith("heln")); 
        Assert.Equal(false, t.StartsWith("hell"));
        Assert.Equal(false, t.StartsWith("helno"));
        Assert.Equal(true, t.StartsWith("hel"));
        Assert.Equal(true, t.Search("help"));
    }
}
