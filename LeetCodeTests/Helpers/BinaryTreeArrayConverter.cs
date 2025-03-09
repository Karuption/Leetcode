using LeetCode.LeetCodeTypes;

namespace LeetCodeTests.Helpers;

public static class BinaryTreeConverter {
    public static TreeNode ToTree(this int[] array) {
        ArgumentNullException.ThrowIfNull(nameof(array));

        return toTree(array.AsSpan(), 0) ?? new TreeNode();
    }

    private static TreeNode? toTree(ReadOnlySpan<int> array, int i) {
        TreeNode? node = null;

        if (i < array.Length)
            node = new TreeNode {
                val = array[i],
                left = toTree(array, 2 * i + 1),
                right = toTree(array, 2 * i + 1 + 2)
            };

        return node;
    }
}
