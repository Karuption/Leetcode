using LeetCode.Easy._3110._Score_of_a_String;

namespace LeetCodeTests.Easy._3110_Score_of_a_String;

public class BaseCases {
    [Theory]
    [InlineData("hello", 13)]
    [InlineData("zaz", 50)]
    public void BaseCase(string input, int expected) {
        Solution sut = new();
        var actual = sut.ScoreOfString(input);
        
        Assert.Equal(expected, actual);
    }
}