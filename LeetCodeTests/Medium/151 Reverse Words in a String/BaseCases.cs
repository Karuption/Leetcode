using LeetCode.Medium._151_Reverse_Words_in_a_String;

namespace LeetCodeTests.Medium._151_Reverse_Words_in_a_String;

public class BaseCases {
    [Theory]
    [InlineData("the sky is blue", "blue is sky the")]
    [InlineData("  hello world  ", "world hello")]
    [InlineData("a good   example", "example good a")]
    public void BaseCases_Reverse_Words_in_a_(string input, string expected) {
        Solution sut = new();

        var result = sut.ReverseWords(input);

        Assert.Equal(expected, result);
    }
}
