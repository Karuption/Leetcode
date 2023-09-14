using Leetcode.Hard._68_Text_Justification;
namespace LeetCodeTests.Hard._68_Text_Justification; 

public class SolutionTests {
    [Theory]
    [InlineData(
        new[] { "This", "is", "an", "example", "of", "text", "justification." }, 16,
        new[] { "This    is    an", "example  of text", "justification.  " })]
    [InlineData(
        new[] { "What", "must", "be", "acknowledgment", "shall", "be" }, 16,
        new[] { "What   must   be", "acknowledgment  ", "shall be        " })]
    [InlineData(
        new[] {
            "Science", "is", "what", "we", "understand", "well", "enough", "to", "explain", "to", "a", "computer.",
            "Art", "is", "everything", "else", "we", "do"
        }, 20,
        new[] {
            "Science  is  what we", "understand      well", "enough to explain to", "a  computer.  Art is",
            "everything  else  we", "do                  "
        })]
    public void BaseCases(string[] input, int width, string[] expected) {
        var sut = new Solution();
        var actual = sut.FullJustify(input, width);
        
        Assert.Equal(expected, actual);
    }
}