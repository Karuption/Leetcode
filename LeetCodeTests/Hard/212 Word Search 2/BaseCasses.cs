using Leetcode.Hard._212_Word_Search_2;

namespace LeetCodeTests.Hard._212_Word_Search_2;

public class BaseCases {
    //XUnit inlineData doesn't allow for multi-demensional arrays.
    private static char[][] baseCase1Board = new char[][] {
        new char[]{ 'o', 'a', 'a', 'n' },
        new char[]{ 'e', 't', 'a', 'e' },
        new char[]{ 'i', 'h', 'k', 'r' },
        new char[]{ 'i', 'f', 'l', 'v' }
    };

    [Fact]
    public void WordSearchBaseCase1() {
        string[] words = new string[] { "oath", "pea", "eat", "rain" };
        string[] output = new string[] { "oath", "eat" };

        SearchWord search = new();
        var sut = search.FindWords( baseCase1Board,words.AsSpan());

        Assert.NotEmpty(sut);
        Assert.Equal(output.Length, sut.Count());
        Assert.Equal(output, sut, StringComparer.InvariantCulture);
    }

    private char[][] baseCase2Board = new char[][] { new char[] { 'a', 'b' }, new char[] { 'c', 'd' } };

    [Fact]
    public void WordSearchBaseCase2() {
        string[] words = new string[] { "abcb" };
        string[] output = Array.Empty<string>();

        SearchWord search = new();
        var sut = search.FindWords( baseCase2Board, words.AsSpan());
        
        Assert.Empty(sut);
    }
}