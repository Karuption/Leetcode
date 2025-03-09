namespace LeetCode.Easy._1971._Find_if_Path_Exists_in_Graph;

public class Solution {
    public bool ValidPath(int n, int[][] edges, int source, int destination) {
        if (source == destination)
            return true;

        var map = new HashSet<int>[n];

        foreach (var edge in edges) {
            map[edge[0]] ??= new HashSet<int>();
            map[edge[0]].Add(edge[1]);

            map[edge[1]] ??= new HashSet<int>();
            map[edge[1]].Add(edge[0]);
        }

        Queue<int> q = new();
        q.Enqueue(source);

        int current;
        HashSet<int> visited = new();

        while (q.Count > 0) {
            current = q.Dequeue();
            if (current == destination)
                return true;

            visited.Add(current);

            foreach (var item in map[current]) {
                if (!q.Contains(item) && !visited.Contains(item))
                    q.Enqueue(item);
            }
        }

        return false;
    }
}