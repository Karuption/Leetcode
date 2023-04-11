using Leetcode.Medium._2390_Removing_Stars_From_a_String;

namespace LeetCodeTests.Medium._2390_Removing_Stars_From_a_String;

public class BaseCases {
    [Theory]
    [InlineData("leet**cod*e", "lecoe")]
    [InlineData("erase*****", "")]
    public void BaseCase(string input, string expected) {
        var sut = new Solution();

        var actual = sut.RemoveStars(input);

        Assert.Equal(expected, actual);
    }
}