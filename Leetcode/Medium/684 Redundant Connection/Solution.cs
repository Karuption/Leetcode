using System.Runtime.CompilerServices;

namespace LeetCode.Medium._684_Redundant_Connection;

public class Solution {
    public int[] FindRedundantConnection(int[][] edges) {
        UnionFind<int> unionFind = new(Enumerable.Range(1, edges.Length));
        foreach (var edge in edges) {
            if (!unionFind.Union(edge))
                return edge;
        }

        return null;
    }
}

public class UnionFind<T> where T : notnull {
    private readonly Dictionary<T, int> _symbolResolver;
    private readonly int[] _elements;
    private readonly int[] _size;
    public int Count { get; private set; }

    public UnionFind(IEnumerable<T> symbols) {
        T[] symbolsArray = symbols as T[] ?? symbols.ToArray();
        _elements = Enumerable.Range(0, symbolsArray.Count()).ToArray();
        _symbolResolver = new Dictionary<T, int>(_elements.Length);
        for (var i = 0; i < _elements.Length; i++)
            _symbolResolver.Add(symbolsArray[i], i);

        _size = new int[_elements.Length].Select(x => 1).ToArray();
        Count = _elements.Length;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool Union(T[] edge) {
        return Union(edge[0], edge[1]);
    }

    public bool Union(T source, T destination) {
        var sourceRoot = Find(_symbolResolver[source]);
        var destRoot = Find(_symbolResolver[destination]);

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