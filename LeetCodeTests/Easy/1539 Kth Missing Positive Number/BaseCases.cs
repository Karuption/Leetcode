
using LeetCode.Easy._1539_Kth_Missing_Positive_Number;

namespace LeetCodeTests.Easy._1539_Kth_Missing_Positive_Number;

public class BaseCases {

    [Theory]
    [InlineData(new[] { 2, 3, 4, 7, 11 }, 5, 9)]
    [InlineData(new[] { 2, 3, 4, 7, 11 }, 4, 8)]
    [InlineData(new[] { 2, 3, 4, 7, 11 }, 1, 1)]
    [InlineData(new[] { 1, 2, 3, 4 }, 2, 6)]
    [InlineData(new[] { 2, 4, 5}, 2, 3)]
    [InlineData(new[]{5, 6, 7, 8, 9},9,14)]
    public void BaseCase(int[] arr, int k, int expected) {
        var solution = new Solution();
        var actual = solution.FindKthPositive(arr, k);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void UpperBoundTest() {
        var solution = new Solution();
        Span<int> arr = new int[1000];
        for(int i = 0; i < arr.Length; i++) {
            arr[i] = i + 1;
        }

        arr[^2]++;
        arr[^1]++;
        
        var actual = solution.FindKthPositive(arr, 1);
        
        Assert.Equal(arr.Length-1, actual);
    }
    
    [Fact]
    public void LowerBoundTest() {
        Span<int> arr = new int[1000];
        
        for(int i = 0; i < arr.Length; i++) {
            arr[i] = i + 2;
        }
        
        
        var solution = new Solution();
        var actual = solution.FindKthPositive(arr, 1);
        
        Assert.Equal(1, actual);
    }
}