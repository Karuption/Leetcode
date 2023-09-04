using System.Runtime.CompilerServices;

namespace Leetcode.Medium._221_Maximal_Square; 

public class Solution {
    public int MaximalSquare(char[][] matrix) {
        int size = int.MinValue;
 
        for (int i = 0; i < matrix.Length; i++) {
            for (int j = 0; j < matrix[0].Length; j++) {
                for (int offset = 0; i+offset < matrix.Length && j+offset < matrix[0].Length; offset++) {
                    
                    //check the new row for '0's
                    for (var index = j; index < j + offset + 1; index++) {
                        
                        var element = matrix[i + offset][index];
                        if (element == '0') {
                            j = index;
                            goto colSkipLabel;
                        }
                    }

                    // check the new Column for '0's
                    for (int row = i; row < i+offset; row++) {
                        if (matrix[row][j+offset] == '0') {
                            goto colSkipLabel;
                        }
                    }

                    size = Math.Max(size, offset + 1);
                }
                colSkipLabel: ;
            }
        }

        return size * size;
    }
}