/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public TreeNode InvertTree(TreeNode root) {
        if (root == null) return null;
        
        var stack = new Stack<TreeNode>();
        stack.Push(root);
        
        while (stack.TryPop(out var node))
        {
            var temp = node.left;
            node.left = node.right;
            node.right = temp;

            if (node.right != null)
                stack.Push(node.right);
            if (node.left != null)
                stack.Push(node.left);
        }
        
        return root;
    }
}