using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leetcode._212_Word_Search_2;

namespace LeetCodeTests._212_Word_Search_2;
public class TrieTests {
    [Fact]
    public void TrieTest() {
        Trie t = new();

        t.Insert("hello");
        t.Insert("helno");

        Assert.Equal(t.Search("hello"), true);
        Assert.Equal(t.Search("helno"), true);
        Assert.Equal(t.StartsWith("heln"), true);
        Assert.Equal(t.StartsWith("hell"), true);

        Assert.Equal(t.StartsWith("on"), false);
    }

    [Fact]
    public void RemovalTest() {
        Trie t = new();

        t.Insert("hello");
        t.Insert("helno");

        t.Remove("helno");

        //Assert.Equal(false, t.StartsWith("heln")); //Need to add functionality to remove hanging letters
        Assert.Equal(true, t.Search("hello"));
    }
}
