﻿namespace Leetcode.Easy._226_Invert_Binary_Tree;

/**
 * * Definition for a binary tree node.
 */
public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

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