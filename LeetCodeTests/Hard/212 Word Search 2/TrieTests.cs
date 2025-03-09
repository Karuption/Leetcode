using LeetCode.Hard._212_Word_Search_2;

namespace LeetCodeTests.Hard._212_Word_Search_2;
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
