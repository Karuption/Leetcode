using LeetCode.Easy._26_Remove_Duplicates_from_Sorted_Array;

namespace LeetCodeTests.Easy._26_Remove_Duplicates_from_Sorted_Array;

public class BaseCases {
    [Theory]
    [InlineData(2, new[] { 1, 1, 2 }, new[] { 1, 2 })]
    [InlineData(5, new[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, new[] { 0, 1, 2, 3, 4 })]
    public void BaseCase(int k, int[] nums, int[] expected) {
        Solution sut = new();

        var result = sut.RemoveDuplicates(nums);

        Assert.Equal(k, result);

        Assert.Equal(expected, nums.Take(k));
    }
}
