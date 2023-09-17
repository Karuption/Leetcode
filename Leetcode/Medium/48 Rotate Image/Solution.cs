namespace Leetcode.Medium._48_Rotate_Image; 

public class Solution {
    public void Rotate(int[][] matrix) {
        for(var i = 0; i < matrix.Length; i++) {
            for(var j = i; j < matrix[0].Length; j++)
                (matrix[i][j], matrix[j][i]) = (matrix[j][i], matrix[i][j]);
        }

        for(var i = 0; i < matrix.Length; i++) 
            Array.Reverse(matrix[i]);
    }
}