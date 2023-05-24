namespace Leetcode.Medium._684_Redundant_Connection;

public class Solution {
    public int[] FindRedundantConnection(int[][] edges) {
        var unionFind = new UnionFind(edges.Length);
        foreach (var edge in edges) {
            if (!unionFind.Union(edge))
                return edge;
        }

        return null;
    }
}

public class UnionFind {
    private readonly int[] _elements;
    private readonly int[] _size;
    public int Count { get; private set; }

    public UnionFind(int count) {
        count++;
        _elements = Enumerable.Range(0, count).ToArray();
        _size = new int[count].Select(x => 1).ToArray();
        Count = count;
    }

    public bool Union(int[] edge) {
        return Union(edge[0], edge[1]);
    }

    public bool Union(int source, int destination) {
        var sourceRoot = Find(source);
        var destRoot = Find(destination);

        if (sourceRoot == destRoot)
            return false;

        if (_size[sourceRoot] > _size[destRoot]) {
            // dest -> source
            _size[sourceRoot] += _size[destRoot];
            _elements[destRoot] = _elements[sourceRoot];
        } else {
            // source -> dest
            _size[destRoot] += _size[sourceRoot];
            _elements[sourceRoot] = _elements[destRoot];
        }

        --Count;
        return true;
    }

    public int Find(int id) {
        if (id == _elements[id])
            return id;

        // Route compression
        // Find root
        var current = _elements[id];
        while (current != _elements[current])
            current = _elements[current];

        // Set everything in the path to root, to the root
        var root = current;
        current = id;
        while (current != root)
            (_elements[current], current) = (root, _elements[current]);

        return root;
    }
}