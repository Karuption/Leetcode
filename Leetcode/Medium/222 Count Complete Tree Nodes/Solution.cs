using LeetCode.LeetCodeTypes;

namespace LeetCode.Medium._222_Count_Complete_Tree_Nodes;

public class Solution {
    private int count;
    public int CountNodes(TreeNode? root) {
        if (root is null) 
            return 0;
        
        count++;
        CountNodes(root.left);
        CountNodes(root.right);

        return count;
    }
}