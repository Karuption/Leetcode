using Leetcode.Medium._1404._Number_of_Steps_to_Reduce_a_Number_in_Binary_Representation_to_One;

namespace LeetCodeTests.Medium._1404._Number_of_Steps_to_Reduce_a_Number_in_Binary_Representation_to_One;

public class BaseCases {
     [Theory]
     [InlineData("1101", 6)]
     [InlineData("1001", 7)]
     [InlineData("10", 1)]
     [InlineData("1", 0)]
     public void BaseCase(string input, int expected) {
          var sut = new Solution();
          var actual = sut.NumSteps(input);
          Assert.Equal(expected, actual);
     }
}