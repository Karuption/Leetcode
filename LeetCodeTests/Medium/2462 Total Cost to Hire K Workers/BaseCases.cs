namespace LeetCodeTests.Medium._2462_Total_Cost_to_Hire_K_Workers; 

public class BaseCases {
    [Theory]
    // split
    [InlineData(new[]{17,12,10,2,7,2,11,20,8}, 3, 4, 11)]
    [InlineData(new[]{17,12,10,2,7,2,2,2,2}, 7, 3, 27)]
    [InlineData(new[]{2,2,2,2,7,10,2}, 7, 3, 27)]
    // single
    [InlineData(new[]{2,2,2,2,7,12,10,2}, 7, 7, 27)]
    [InlineData(new[]{1,2,4,1}, 3, 3, 4)]
    public void BaseCase(int[] cost,int k, int candidates,int expected) {
        var sut = new Leetcode.Medium._2462_Total_Cost_to_Hire_K_Workers.Solution();

        var actual = sut.TotalCost(cost, k, candidates);
        
        Assert.Equal(expected, actual);
    }
}