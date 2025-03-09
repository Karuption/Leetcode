using LeetCode.Easy._1002._Find_Common_Characters;

namespace LeetCodeTests.Easy._1002_Find_Common_Characters;

public class BaseCases {
    [Theory]
    [InlineData(new []{"bella", "label", "roller"}, new []{"e", "l", "l"})]
    [InlineData(new []{"cool", "lock", "cook"}, new []{"c", "o"})]
    public void BsaeCase(string[] input, string[] expected) {
        Solution sut = new();
        var actual = sut.CommonChars(input);
        
        Assert.Equal(expected, actual);
    }
}