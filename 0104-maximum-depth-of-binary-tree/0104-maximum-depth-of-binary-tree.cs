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
    private int max = 0;
    private int cur = 0;
    public int MaxDepth(TreeNode root) {
        if (root == null) return 0;
        
        rec(root);
        return max;
    }
    
    private void rec(TreeNode root)
    {
        max = Math.Max(max, ++cur);
        if (root.left != null)
            rec(root.left);
        if (root.right != null)
            rec(root.right);
        cur--;
    }
}