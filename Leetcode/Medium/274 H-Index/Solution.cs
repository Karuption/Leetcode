namespace Leetcode.Medium._274_H_Index; 

public class Solution {
    public int HIndex(int[] citations) {
        PriorityQueue<int, int> pq = new (citations.Length);
        var current = 0;
        
        foreach (var citation in citations) 
            pq.Enqueue(citation, citation);

        while (pq.Count>0 && pq.Peek() <= pq.Count)
            current = pq.Dequeue();

        return Math.Max(current, pq.Count);
    }
}