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
internal abstract class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
}

public class Solution {
    public int CountNodes(TreeNode root) {
        if (root == null) return 0;
        var count = 1;
        if (root.left != null) count += CountNodes(root.left);

        if (root.right != null) count += CountNodes(root.right);

        return count;
    }
}