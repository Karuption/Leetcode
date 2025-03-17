using LeetCode.Easy._2206_Divide_Array_Into_Equal_Pairs;

namespace LeetCodeTests.Easy._2206_Divide_Array_Into_Equal_Pairs;

public class BaseCases {
    [Theory]
    [InlineData(new[] { 3, 2, 3, 2, 2, 2 }, true)]
    [InlineData(new[] { 1, 2, 3, 4 }, false)]
    public void BaseCasesTests(int[] nums, bool expected) {
        var sut = new Solution();
        var result = sut.DivideArray(nums);
        Assert.Equal(expected, result);
    }
}