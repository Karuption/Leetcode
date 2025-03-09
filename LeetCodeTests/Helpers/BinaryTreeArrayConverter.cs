using LeetCode.LeetCodeTypes;

namespace LeetCodeTests.Helpers;

public static class BinaryTreeConverter {
    public static TreeNode? ToTree(this int[] array) {
        return ToTree(array, 0);
    }

    private static TreeNode? ToTree(this ReadOnlySpan<int> array, int i) {
        if (i < array.Length)
            return new TreeNode {
                val = array[i],
                left = ToTree(array, 2 * i + 1),
                right = ToTree(array, 2 * i + 2)
            };

        return null;
    }
}
