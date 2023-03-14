using System.Security;
using Leetcode.Hard._212_Word_Search_2;

namespace Leetcode.Medium._129_Sum_Root_to_Leaf_Numbers; 

//Definition for a binary tree node.
 public class TreeNode {
     public int val;
     public TreeNode? left;
     public TreeNode? right;
     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
         this.val = val;
         this.left = left;
         this.right = right;
     }
 }
 
 public class Solution {
     public int SumNumbers(TreeNode root) {
         var sum = 0;
         var previousNodes = 0;
         
         SumNumbers(root, ref sum, ref previousNodes);
         
         return sum;
     }

     private static void SumNumbers(TreeNode root, ref int sum, ref int previousNodes) {
         if (root is null)
             return;

         previousNodes = previousNodes * 10 + root.val;

         if (root.left is null && root.right is null)
             sum += previousNodes;

         SumNumbers(root.left, ref sum,ref previousNodes);
         SumNumbers(root.right, ref sum, ref previousNodes);
         previousNodes /= 10;
     }
 }