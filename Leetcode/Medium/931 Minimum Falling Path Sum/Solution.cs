namespace LeetCode.Medium._931_Minimum_Falling_Path_Sum;

public class Solution {
    public int MinFallingPathSum(int[][] matrix) {
        for (var i = matrix.Length - 2; i >= 0; i--) {
            var bRow = i + 1;

            matrix[i][0] += Math.Min(matrix[bRow][0], matrix[bRow][1]);
            matrix[i][^1] += Math.Min(matrix[bRow][^1], matrix[bRow][^2]);
            
            for (var j = 1; j <= matrix[i].Length-2; j++) {
                var bLeft  = matrix[bRow][j - 1];
                var bottom = matrix[bRow][j];
                var bRight = matrix[bRow][j + 1];
             
                matrix[i][j] += Math.Min(Math.Min(bLeft, bottom), bRight);
            }
        }
        return matrix[0].Min();
    }
}