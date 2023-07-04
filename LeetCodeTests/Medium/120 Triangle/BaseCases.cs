using System.Collections;
using Leetcode.Medium._120_Triangle;

namespace LeetCodeTests.Medium._120_Triangle; 

public class BaseCases {
    [Theory]
    [MemberData(nameof(leetcodeCases))]
    public void BaseCase(IList<IList<int>> triangle, int expected) {
        var sut = new Solution();
        var actual = sut.MinimumTotal(triangle);
        Assert.Equal(expected, actual);
    }

    public static object[][] leetcodeCases() {
        var output = new List<object[]>();

        output.Add(new object[]{(IList<IList<int>>)new List<IList<int>> { new List<int>(){ 2 }, new List<int>(){ 3, 4 }, new List<int>(){ 6, 5, 7 }, new List<int>(){ 4, 1, 8, 3 } }, 11});
        output.Add(new object[]{(IList<IList<int>>)new List<IList<int>> { new List<int>(){ -10 } }, -10});

        return output.ToArray();
    }
}