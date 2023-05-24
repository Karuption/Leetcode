namespace LeetCodeTests.Easy._703_Kth_Largest_Element_in_a_Stream;

public class KthLargest {
    [Theory]
    [InlineData(3, new[] { 4, 5, 8, 2 }, new[] { 3, 5, 10, 9, 4 }, new[] { 4, 5, 5, 8, 8 })]
    [InlineData(1, new int [0], new[] { -3, -2, -4, 0, 4 }, new[] { -3, -2, -2, 0, 4 })]
    [InlineData(2, new[] { 0 }, new[] { -1, 1, -2, -4, 3 }, new[] { -1, 0, 0, 0, 1 })]
    [InlineData(3, new[] { 5, -1 }, new[] { 2, 1, -1, 3, 4 }, new[] { -1, 1, 1, 2, 3 })]
    [InlineData(7, new[] { -10, 1, 3, 1, 4, 10, 3, 9, 4, 5, 1 },
        new[] { 3, 2, 3, 1, 2, 4, 5, 5, 6, 7, 7, 8, 2, 3, 1, 1, 1, 10, 11, 5, 6, 2, 4, 7, 8, 5, 6 },
        new[] { 3, 3, 3, 3, 3, 3, 4, 4, 4, 5, 5, 5, 5, 5, 5, 5, 5, 6, 7, 7, 7, 7, 7, 7, 7, 7, 7 })]
    public void Basecase(int k, int[] array, int[] additions, int[] expected) {
        var sut = new Leetcode.Easy._703_Kth_Largest_Element_in_a_Stream.KthLargest(k, array);

        for (var i = 0; i < additions.Length; i++) {
            var actual = sut.Add(additions[i]);
            Assert.Equal(expected[i], actual);
        }
    }
}
