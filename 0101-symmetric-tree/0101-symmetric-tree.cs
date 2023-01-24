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
    public bool IsSymmetric(TreeNode root) {
        if (root.left == null && root.right == null)
            return true;
        if (root.left == null ^ root.right == null)
            return false;
        
        var stack = new Stack<(TreeNode left, TreeNode right)>();
        stack.Push((root.left, root.right));
        
        while (stack.TryPop(out var pair))
        {
            var (left, right) = (pair.left, pair.right);
            if (left.val != right.val) return false;
            
            if (left.right != null && right.left != null)
                stack.Push((left.right, right.left));
            else if (left.right == null ^ right.left == null)
                return false;
            
            if (left.left != null && right.right != null)
                stack.Push((left.left, right.right));
            else if (left.left == null ^ right.right == null)
                return false;
        }
        
        return true;
    }
}