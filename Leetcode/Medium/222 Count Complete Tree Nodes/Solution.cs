namespace Leetcode.Medium._222_Count_Complete_Tree_Nodes;

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 * public int val;
 * public TreeNode left;
 * public TreeNode right;
 * public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 * this.val = val;
 * this.left = left;
 * this.right = right;
 * }
 * }
 */
public abstract class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
}

public class Solution {
    private int count = 0;
    public int CountNodes(TreeNode root) {
        if (root == null) return 0;
        
        this.count++;
        CountNodes(root.left);
        CountNodes(root.right);

        return this.count;
    }
}