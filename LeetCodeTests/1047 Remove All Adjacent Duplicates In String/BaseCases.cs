using Leetcode._1047_Remove_All_Adjacent_Duplicates_In_String;

namespace LeetCodeTests._1047_Remove_All_Adjacent_Duplicates_In_String;

public class BaseCases {
    [Theory]
    [InlineData("abbaca", "ca")]
    [InlineData("azxxzy", "ay")]
    public void BaseCase(string input, string expected) {
        var sut = new Solution();

        var result = sut.RemoveDuplicates(input);

        Assert.Equal(expected, result);
    }
}
