namespace LeetCode.Medium._207_Course_Schedule;

public class Solution {
    private HashSet<int>[] mapping = null!;
    private bool[] visited = null!;

    public bool CanFinish(int numCourses, int[][] prerequisites) {
        mapping = Enumerable.Range(0, numCourses).Select(x => new HashSet<int>()).ToArray();
        visited = new bool[numCourses];

        foreach (var edge in prerequisites)
            // [a,b] you must take b to take a
            mapping[edge[0]].Add(edge[1]);

        while (TakeEligibleClasses() > 0)
            ;

        foreach (HashSet<int> edge in mapping) {
            if (edge.Count > 0)
                return false;
        }

        return true;
    }

    private int TakeEligibleClasses() {
        var count = 0;
        for (var i = 0; i < mapping.Length; i++) {
            // Get a class with 0 in degree
            if (mapping[i].Count == 0 && visited[i] == false) {
                visited[i] = true;
                count += RemovePrereq(i);
            }
        }

        return count;
    }

    private int RemovePrereq(int i) {
        var count = 0;

        for (var j = 0; j < mapping.Length; j++) {
            if (mapping[j].Contains(i)) {
                mapping[j].Remove(i);
                count++;
            }
        }

        return count;
    }
}