namespace LeetCode.Medium._547_Number_of_Provinces;
// You are given an n x n matrix isConnected where isConnected[i][j] = 1
// if the ith city and the jth city are directly connected
// isConnected[i][j] = 0 otherwise.
//
// Return the total number of provinces.

public class Solution {
    public int FindCircleNum(int[][] isConnected) {
        var unionFind = new UnionFind(isConnected[0].Length);

        for (var i = 0; i < isConnected[0].Length; i++) {
            for (var j = 0; j < isConnected[i].Length; j++) {
                if (isConnected[i][j] == 1)
                    unionFind.Union(i, j);
            }
        }

        return unionFind.Count;
    }
}

public class UnionFind {
    private readonly int[] _element;
    private readonly int[] _size;
    public int Count { get; private set; }

    public UnionFind(int componentNumber) {
        Count = componentNumber;
        _element = Enumerable.Range(0, componentNumber).ToArray();
        _size = new int[componentNumber].Select(x => 1).ToArray();
    }

    public void Union(int source, int destination) {
        var sourceRoot = Find(source);
        var destinationRoot = Find(destination);

        if (sourceRoot == destinationRoot)
            return;

        if (_size[sourceRoot] > _size[destinationRoot]) {
            //destination -> source
            _size[sourceRoot] += _size[destinationRoot];
            _element[destinationRoot] = sourceRoot;
            --Count;
        } else {
            //source -> destination
            _size[destinationRoot] += _size[sourceRoot];
            _element[sourceRoot] = destinationRoot;
            --Count;
        }
    }

    public int Find(int id) {
        var root = _element[id];

        // If this is the root component.
        if (id == root)
            return root;

        // Route compression
        // Find the root of this component
        var current = id;
        while (_element[current] != current) current = _element[current];

        // Apply the root to all members of this component
        root = current;
        current = id;
        while (current != root) (_element[current], current) = (root, _element[current]);

        return root;
    }
}