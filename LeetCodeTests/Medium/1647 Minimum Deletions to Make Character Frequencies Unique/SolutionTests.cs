using LeetCode.Medium._1647_Minimum_Deletions_to_Make_Character_Frequencies_Unique;

namespace LeetCodeTests.Medium._1647_Minimum_Deletions_to_Make_Character_Frequencies_Unique; 

public class SolutionTests {
    [Theory]
    [InlineData("aab", 0)]
    [InlineData("aaabbbcc", 2)]
    [InlineData("ceabaacb", 2)]
    public void BaseCases(string input, int expected) {
        var sut = new Solution();
        var actual = sut.MinDeletions(input);
        
        Assert.Equal(expected, actual);
    }

}