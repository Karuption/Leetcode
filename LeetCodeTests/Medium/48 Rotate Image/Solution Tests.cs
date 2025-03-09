using LeetCode.Medium._48_Rotate_Image;

namespace LeetCodeTests.Medium._48_Rotate_Image; 

public class Solution_Tests {
    [Theory]
    [MemberData(nameof(ValueGenerators))]
    public void BaseCases(int[][] actual, int[][] expected) {
        var sut = new Solution();
        sut.Rotate(actual);
        
        Assert.Equal(expected, actual);
    }
    
    public static IEnumerable<object[]> ValueGenerators() {
        List<object[]> output = new();

        output.Add(new object[] {new int[][] { new[] { 5, 1, 9, 11 }, new[] { 2, 4, 8, 10 }, new[] { 13, 3, 6, 7 }, new[] { 15, 14, 12, 16 } },
            new[] { new[] { 15, 13, 2, 5 }, new[] { 14, 3, 4, 1 }, new[] { 12, 6, 8, 9 }, new[] { 16, 7, 10, 11 } }});
        
        output.Add(new object[] {new int[][] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { 7, 8, 9 } },
            new[] { new[] { 7, 4, 1 }, new[] { 8, 5, 2 }, new[] { 9, 6, 3 } }});

        return output;
    }
}