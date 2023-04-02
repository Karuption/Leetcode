using Leetcode.LeetCodeTypes;

namespace Leetcode.Easy._226_Invert_Binary_Tree;

public class Solution {
    public TreeNode? InvertTree(TreeNode root) {
        if (root is null)
            return null;
        (root.left, root.right) = (root.right, root.left);
        InvertTree(root.left);
        InvertTree(root.right);
        return root;
    }
}