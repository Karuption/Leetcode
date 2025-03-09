namespace LeetCode.Hard._295_Find_Median_from_Data_Stream;

public class MedianFinder {
    private readonly List<int> _data = new();

    public void AddNum(int num) {
        var left = 0;
        var right = _data.Count;
        int middle;
        int compare;

        while (left < right) {
            middle = left + (right - left) / 2;
            compare = _data[middle].CompareTo(num);
            if (compare > 0) {
                right = middle;
            }
            else if (compare < 0) {
                left = middle + 1;
            }
            else {
                _data.Insert(middle, num);
                return;
            }
        }

        _data.Insert(left, num);
    }

    public double FindMedian() {
        if (_data.Count % 2 == 0)
            return (_data[(_data.Count - 1) / 2] + _data[_data.Count / 2]) / 2d;
        return _data[(_data.Count - 1) / 2];
    }
}