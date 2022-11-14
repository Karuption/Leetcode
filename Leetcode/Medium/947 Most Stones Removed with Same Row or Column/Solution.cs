namespace Leetcode.Medium._947_Most_Stones_Removed_with_Same_Row_or_Column;

public class Solution {
    public int RemoveStones(int[][] stones) {
        UnionFind uf = new(stones);

        foreach (var stone in stones) uf.Union(stone[0] + 1, -(stone[1] + 1));

        return stones.Length - uf.count;
    }
}

public class UnionFind {
    private readonly Dictionary<int, int> mapping = new();
    private readonly Dictionary<int, int> rank = new();
    public int count;

    public UnionFind(int[][] stones) {
        foreach (var stone in stones) {
            var x = stone[0] + 1;
            var y = -(stone[1] + 1);
            mapping[x] = x;
            rank[x] = 0;
            mapping[y] = y;
            rank[y] = 0;
        }

        count = mapping.Count;
    }

    public int find(int node) {
        if (mapping[node] != node) return find(mapping[node]);
        return mapping[node];
    }

    public void Union(int x, int y) {
        var xSet = find(x);
        var ySet = find(y);
        if (xSet == ySet) return;
        count--;

        if (rank.GetValueOrDefault(xSet) > rank.GetValueOrDefault(ySet)) {
            mapping[ySet] = mapping[xSet];
        }

        else if (rank.GetValueOrDefault(xSet) < rank.GetValueOrDefault(ySet)) {
            mapping[xSet] = mapping[ySet];
        }

        else {
            mapping[xSet] = mapping[ySet];
            rank[xSet] = rank.GetValueOrDefault(ySet) + 1;
        }
    }
}