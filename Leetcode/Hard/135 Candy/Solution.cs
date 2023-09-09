namespace Leetcode.Hard._135_Candy; 

public class Solution {
    public int Candy(int[] ratings) {
        if(ratings.Length < 2)
            return ratings.Length;

        int candy = 0;
        int last = 0;
        int valley = -1;
        int trend = 1;
        int peak = 0;

        for(int i = 0; i < ratings.Length - 1; i++) {
            if(ratings[i] < ratings[i+1]) {
                if(trend != 1) {
                    int n = i + 1 - valley;
                    candy += Math.Max(peak, n) + (n*(n-1))/2; 

                    valley = -1;
                    last = 1;
                } else
                    candy += ++last;
                trend = 1;
                continue;
            }

            if(ratings[i] == ratings[i+1]) {
                if(trend == 1) 
                    candy += last + 1;
                else  if(valley == i)
                    candy++;
                else {
                    int n = i + 1 - valley;
                    candy += Math.Max(peak, n) + (n*(n-1))/2; 
                }
                peak = last = 1;
                valley = i+1;
                trend = -1;
            }

            if(valley < 0) {
                valley = i;
                trend = -1;
                peak = last + 1;
                last = 1;
            }
        }

        Console.WriteLine($"end of loop {candy}");

        if(ratings[^1] > ratings[^2] && trend == 1) {
            Console.WriteLine($"peak {peak} valley {valley} last {last}");
            candy += last+1;
        } else {
            Console.WriteLine($"peak {peak} valley {valley} last {last}");
            if(valley >= 0) {
                int n = ratings.Length - valley;
                candy += Math.Max(peak, n) + (n*(n-1))/2;
            } else 
                candy+=last+1;
        }

        return candy;  
    }
}