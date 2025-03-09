using LeetCode.Hard._212_Word_Search_2;

namespace LeetCodeTests.Hard._212_Word_Search_2;
public class TrieTests {
    [Fact]
    public void Insert_ShouldFindWordAndPrefix() {
        Trie t = new(new[] { "hello", "helno" },'$');

        Assert.True(t.Search("hello"));
        Assert.True(t.Search("helno"));
        Assert.True(t.StartsWith("heln"));
        Assert.True(t.StartsWith("hell"));

        Assert.False(t.StartsWith("on"));
    }

    [Fact]
    public void Remave_ShouldRemoveAsManyNodesAsPossible() {
        Trie t = new(new[] { "hello", "helno" }, '$');

        t.Remove("helno");

        Assert.False(t.StartsWith("heln")); 
        Assert.False(t.Search("helno")); 
        Assert.True(t.Search("hello"));
    }

    [Fact]
    public void MultipleRemoval_ShouldRemoveAsManyNodesAsPossible() {
        Trie t = new(new[] { "hello", "hella", "helno", "help" }, '$');

        t.Remove(new []{"hello","hella", "helno"});

        Assert.False(t.Search("heln")); 
        Assert.False(t.Search("hell"));
        Assert.False(t.Search("helno"));
        Assert.False(t.Search("hel"));
        Assert.False(t.StartsWith("heln")); 
        Assert.False(t.StartsWith("hell"));
        Assert.False(t.StartsWith("helno"));
        
        Assert.True(t.StartsWith("hel"));
        Assert.True(t.Search("help"));
    }
}
