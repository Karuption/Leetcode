using LeetCode.Easy._1791._Find_Center_of_Star_Graph;

namespace LeetCodeTests.Easy._1791_Find_Center_of_Star_Graph;

public class BaseCases {

    private static readonly int[][] _data1 = [[1, 2], [2, 3], [4, 2]];
    private static readonly int[][] _data2 = [[1, 2], [5, 1], [1, 3], [1, 4]];
    
    public static object[][] _case1 => [[_data1, 2], [_data2,1],];
    
    [Theory]
    [MemberData(nameof(_case1))]
    public void BaseCase(int[][] input, int expected) {
        var sut = new Solution();
        var actual = sut.FindCenter(input);
        
        Assert.Equal(expected, actual);
    }
}