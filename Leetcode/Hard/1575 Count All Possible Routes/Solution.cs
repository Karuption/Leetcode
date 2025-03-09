using System.Runtime.CompilerServices;

namespace LeetCode.Hard._1575_Count_All_Possible_Routes; 

public class Solution {
    private Dictionary<int, Dictionary<int, int>> Memo = new();
    private int[,] _dp = null!;
    private int[] _locations = null!;

    public int CountRoutes(int[] locations, int start, int finish, int fuel) {
        _locations = locations;
        _dp = new int[locations.Length, fuel + 1];
        for (int i = 0; i < locations.Length; i++) {
            for (int j = 0; j < fuel+1; j++) {
                _dp[i,j] = -1;
            }
        }
        return countRoutes(start, finish, fuel);
    }

    private int countRoutes(int current, int finish, int fuel) {
        //if we can't get to the finish
        if (fuel < 0)
            return 0;
        
        if (_dp[current, fuel] != -1)
            return _dp[current,fuel];
        
        var count = 0;
        if (current == finish)
            count++;
        
        //if there is gas to go to other places
        for (var i = 0; i < _locations.Length; i++) {
            if(current == i)
                continue;

            var fuelLeft = fuel - GetDistance(current, i);
            count = (count + countRoutes(i, finish, fuelLeft) )% 1_000_000_007;
        }

        return _dp[current, fuel] = count;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private int GetDistance(int from, int to) {
        return Math.Abs(_locations[from] - _locations[to]);
    }
}