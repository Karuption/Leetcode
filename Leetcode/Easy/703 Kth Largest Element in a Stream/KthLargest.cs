namespace LeetCode.Easy._703_Kth_Largest_Element_in_a_Stream;

/**
 * * Your KthLargest object will be instantiated and called as such:
 * * KthLargest obj = new KthLargest(k, nums);
 * * int param_1 = obj.Add(val);
 * *
 */
public class KthLargest {
    // This is the first attempt, implementing everything myself
    //    private readonly int?[] _kLargest;

//    public KthLargest(int k, int[] nums) {
//        _kLargest = new int?[k];

//        foreach (var num in nums)
//            Add(num);

//        //var orderedNums = nums.OrderByDescending(x => x).ToArray();
//        //for (var i = 0; i < orderedNums.Length && i < k; i++)
//        //    _kLargest[i] = orderedNums[i];
//    }

//    public int Add(int val) {
//        if (_kLargest[^1] is null) {
//            NullInsert(val);
//            return _kLargest[^1] ?? val;
//        }

//        if (val < _kLargest[^1])
//            return _kLargest[^1].Value;

//        Insert(val);

//        return _kLargest[^1]!.Value;
//    }

//    private int NullInsert(int val) {
//        var current = 0;

//        while (_kLargest[current] != null && _kLargest[current] > val)
//            current++;

//        // inserting to a null spot
//        if (_kLargest[current] is null) {
//            _kLargest[current] = val;
//            return val;
//        }

//        Shift(current);
//        _kLargest[current] = val;
//        for (var i = _kLargest.Length - 1; i < 0; i--) {
//            if (_kLargest[i] != null)
//                return i;
//        }

//        return 0;
//    }

//    // binary insertion decreasing order
//    private void Insert(int val) {
//        var left = 0;
//        var right = _kLargest.Length - 1;

//        while (left < right) {
//            var mid = (left + right) / 2;
//            if (_kLargest[mid] == val) {
//                left = right = mid;
//                break;
//            }

//            if (_kLargest[mid] < val) {
//                right = mid - 1;
//                continue;
//            }

//            if (_kLargest[mid] > val) {
//                left = mid + 1;
//            }
//        }

//        Shift(left);
//        if (_kLargest[left] > val)
//            _kLargest[left + 1] = val;
//        else
//            _kLargest[left] = val;
//    }

//    private void Shift(int index) {
//        for (var i = _kLargest.Length - 1; i > 0 && index < i; i--) _kLargest[i] = _kLargest[i - 1];
//    }


    private readonly PriorityQueue<int, int> _q;
    private readonly int _k;

    public KthLargest(int k, int[] nums) {
        _q = new PriorityQueue<int, int>(k + 1);

        _k = k;

        foreach (var num in nums)
            Add(num);
    }

    public int Add(int val) {
        _q.Enqueue(val, val);

        while (_q.Count > _k)
            _q.Dequeue();

        return _q.Peek();
    }
}

