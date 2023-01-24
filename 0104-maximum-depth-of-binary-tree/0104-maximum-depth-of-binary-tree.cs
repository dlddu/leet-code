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
    public int MaxDepth(TreeNode root) {
        if (root == null)
            return 0;
        
        var stack = new Stack<(TreeNode node, int depth)>();
        stack.Push((root, 1));
        
        var max = 0;
        
        while (stack.TryPop(out var pair))
        {
            var (node, depth) = pair;
            max = Math.Max(max, depth);
            
            if (node.left != null)
                stack.Push((node.left, depth + 1));
            if (node.right != null)
                stack.Push((node.right, depth + 1));
        }
        
        return max;
    }
}