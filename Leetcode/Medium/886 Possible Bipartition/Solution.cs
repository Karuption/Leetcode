﻿namespace LeetCode.Medium._886_Possible_Bipartition;

public class Solution {
    private static readonly HashSet<int> EmptySet = new();
    private int[] _colors = null!;
    private HashSet<int>?[] _set = null!;

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
        foreach (var item in _set[i] ?? EmptySet) {
            if (_colors[item] == default) {
                _colors[item] = _colors[i] % 2 + 1; //set the opposite color
                if (!Color(item, _colors[i]))
                    return false; //propagate any recursion failures
            } else if (_colors[item] == _colors[i]) {
                return false;
            }
        }

        return true;
    }
}