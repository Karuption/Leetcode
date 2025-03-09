namespace LeetCode.LeetCodeTypes;

public class TreeNode {
    public int val;
    public TreeNode? left;
    public TreeNode? right;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class TreeNode<T> {
    public T val;
    public TreeNode<T>? left;
    public TreeNode<T>? right;

    public TreeNode(T val = default, TreeNode<T> left = null, TreeNode<T> right = null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }

    public static implicit operator TreeNode(TreeNode<T> node) {
        return (TreeNode)(object)node;
    }
}