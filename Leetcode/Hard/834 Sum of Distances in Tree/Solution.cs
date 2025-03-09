namespace LeetCode.Hard._834_Sum_of_Distances_in_Tree;

public class Solution {
    private int n;
    private HashSet<int>?[] set;

    public int[] SumOfDistancesInTree(int n, int[][] edges) {
        if (n < 2)
            return new[] { 0 };
        set = new HashSet<int>?[n];
        var output = new int[n];

        foreach (var edge in edges) {
            set[edge[0]] ??= new HashSet<int>();
            set[edge[0]]!.Add(edge[1]);

            set[edge[1]] ??= new HashSet<int>();
            set[edge[1]]!.Add(edge[0]);
        }

        for (var i = 0; i < set.Length; i++) {
            if (set[i] == null) continue;

            output[i] = totalDistanceSum(i, n);
        }

        return output;
    }

    private int totalDistanceSum(int i, int n) {
        Queue<(int, int)> q = new();
        var cost = new int[n];
        int currentCost;
        int current;

        q.Enqueue((i, 0));
        while (q.Count > 0) {
            (current, currentCost) = q.Dequeue();

            if (cost[current] == 0) {
                cost[current] = currentCost;
                Enqueue(set[current], currentCost + 1, q);
            }
        }

        cost[i] = 0;
        return cost.Sum();
    }

    private static void Enqueue(IEnumerable<int>? list, int cost, Queue<ValueTuple<int, int>> q) {
        if (list is null)
            return;
        foreach (var item in list) q.Enqueue((item, cost));
    }
}