namespace Leetcode.Medium._886_Possible_Bipartition;

public class Solution {
    private static readonly HashSet<int> EmptySet = new();
    private int[] _colors;
    private HashSet<int>?[] _set;

    public bool PossibleBipartition(int n, int[][] dislikes) {
        _set = new HashSet<int>?[n];
        _colors = new int[n];

        foreach (var dislike in dislikes) {
            _set[--dislike[0]] ??= new HashSet<int>();
            _set[dislike[0]]!.Add(--dislike[1]);
            //sneaky decrement on both elements to shift range [1,n] -> [0,n-1]

            _set[dislike[1]] ??= new HashSet<int>();
            _set[dislike[1]]!.Add(dislike[0]);
        }

        for (var i = 0; i < n; i++) {
            if (_colors[i] != 0) continue;

            if (!Color(i, 1))
                return false;
        }

        return true;
    }

    private bool Color(int i, int color) {
        Queue<int> q = new();

        q.Enqueue(i);
        int current;
        while (q.Count > 0) {
            current = q.Dequeue();

            foreach (var item in _set[current] ?? EmptySet) {
                if (_colors[item] == 0) {
                    q.Enqueue(item);
                    _colors[item] = _colors[current] % 2 + 1;
                } else if (_colors[item] == _colors[current]) {
                    return false;
                }
            }
        }

        return true;
    }
}