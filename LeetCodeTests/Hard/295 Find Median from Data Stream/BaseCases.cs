using Leetcode.Hard._295_Find_Median_from_Data_Stream;

namespace LeetCodeTests.Hard._295_Find_Median_from_Data_Stream;

public class BaseCases {
    [Fact]
    public void BaseCase() {
        MedianFinder sut = new();

        var actual = new double[3];

        sut.AddNum(1);
        sut.AddNum(2);

        Assert.Equal(1.5, sut.FindMedian());

        sut.AddNum(3);

        Assert.Equal(2.0d, sut.FindMedian());
    }

    [Fact]
    public void BaseCase2() {
        MedianFinder sut = new();

        var actual = new double[5];

        sut.AddNum(-1);
        Assert.Equal(-1d, sut.FindMedian());
        sut.AddNum(-2);

        Assert.Equal(-1.5d, sut.FindMedian());

        sut.AddNum(-3);
        Assert.Equal(-2d, sut.FindMedian());

        sut.AddNum(-4);
        Assert.Equal(-2.5d, sut.FindMedian());

        sut.AddNum(-5);

        Assert.Equal(-3d, sut.FindMedian());
    }
}
