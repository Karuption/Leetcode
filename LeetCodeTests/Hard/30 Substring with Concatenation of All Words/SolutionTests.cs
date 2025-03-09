using LeetCode.Hard._30_Substring_with_Concatenation_of_All_Words;

namespace LeetCodeTests.Hard._30_Substring_with_Concatenation_of_All_Words;

public class SolutionTests {
    [Theory]
    [InlineData("barfoothefoobarman", new[] { "foo", "bar" }, new[] { 0, 9 })]
    [InlineData("wordgoodgoodgoodbestword", new[] { "word", "good", "best", "word" }, new int[] { })]
    [InlineData("barfoofoobarthefoobarman", new[] { "bar", "foo", "the" }, new[] { 6, 9, 12 })]
    [InlineData("wordgoodgoodgoodbestword", new[]{"word", "good", "best", "good"}, new[]{8})]
    [InlineData("lingmindraboofooowingdingbarrwingmonkeypoundcake", new[]{"fooo","barr","wing","ding","wing"}, new[]{13})]
    public void BaseCases(string s, string[] words, int[] expected) {
        var actual = new Solution().FindSubstring(s, words);
        Assert.Equal(expected, actual);
    }
}