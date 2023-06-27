using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace Leetcode.Medium._2462_Total_Cost_to_Hire_K_Workers; 

public class Solution {
    public long TotalCost(int[] costs,int k,int candidates) {
        //if we don't have to track two sides (candidates takes up the entire range)
        if (candidates * 2 >= costs.Length)
            return AllTotalCost(costs, k);

        //We have to track two sides
        return SplitTotalCost(costs,k,candidates);
    }

    private long AllTotalCost(int[] costs, int k) {
        PriorityQueue<int, int> q = new();

        foreach (var candidateCost in costs) 
            q.Enqueue(candidateCost, candidateCost);

        long output = 0;
        for (int i = 0; i < k; i++)
            output += q.Dequeue();

        return output;
    }    
    
    private long SplitTotalCost(int[] costs,int k,int candidates) {
        PriorityQueue<int, int> rq = new();
        PriorityQueue<int, int> lq = new();
        var l = candidates-1;
        var r = costs.Length-candidates;

        //queue setup
        for (int i = 0; i < candidates; i++) {
            lq.Enqueue(costs[i], costs[i]);
            rq.Enqueue(costs[costs.Length-1-i],costs[costs.Length-1-i]);
        }

        //Sum the minimum with position as a tie breaker
        long output = 0;
        int n = k;
        for (int i = 0; i < k && lq.Count > 0 && rq.Count > 0; i++) {
            if (lq.Peek() <= rq.Peek()) {
                output += lq.Dequeue();
                l++;
                n--;
                if (l < r)
                    lq.Enqueue(costs[l],costs[l]);
            } else {
                output += rq.Dequeue();
                r--;
                n--;
                if(r > l)
                    rq.Enqueue(costs[r],costs[r]);
            }
        }
        
        //if the right is exhausted 
        while (n > 0 && lq.Count > 0) {
            output += lq.Dequeue();
            l++;
            n--;
            if(l<r)
                lq.Enqueue(costs[l], costs[l]);
        }

        //if the left is exhausted
        while (n > 0 && rq.Count > 0) {
            output += rq.Dequeue();
            r--;
            n--;
            if(r>l)
                lq.Enqueue(costs[r], costs[r]);
        }

        return output;
    }
}