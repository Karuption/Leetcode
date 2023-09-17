namespace Leetcode.Medium._73_Set_Matrix_Zeroes; 

public class Solution {
    public void SetZeroes(int[][] matrix) {
        HashSet<int> cq = new ();

        for(var i = 0; i < matrix.Length; i++) {
            var needZeroed = false;
            for(int j = 0; j < matrix[0].Length; j++) {
                if(matrix[i][j] == 0) {
                    cq.Add(j);
                    needZeroed = true;
                }
            }
            
            if(needZeroed)
                Array.Clear(matrix[i]);
        }

        foreach(var col in cq) {
            for(var i = 0; i < matrix.Length; i++) {
                matrix[i][col] = 0;
                Console.WriteLine($"{i} {col}");
            }
        }
    }
}