using LeetCode.Hard._1575_Count_All_Possible_Routes;

namespace LeetCodeTests.Hard._1575_Count_All_Possible_Routes; 

public class BaseCases {
    [Theory]
    [InlineData(new[] { 2,3,6,8,4 }, 1, 3, 5, 4)]
    [InlineData(new [] {4,3,1}, 1, 0, 6, 5)]
    [InlineData(new int[]{5,2,1}, 0, 2, 3, 0)]
    [InlineData(new int[]{1,2,3}, 0, 2, 40, 615088286)]

    public void BaseCase(int[] locations, int start, int finish, int fuel, int expected) {
        var sut = new Solution();

        var actual = sut.CountRoutes(locations, start, finish, fuel);
        
        Assert.Equal(expected, actual);
    }
}