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
    public int SumOfLeftLeaves(TreeNode root) {
        if (root == null) return 0;
        
        var stack = new Stack<(TreeNode node, bool isLeft)>();
        stack.Push((root, false));
        var sum = 0;
        
        while (stack.TryPop(out var pair))
        {
            var (node, isLeft) = pair;
            
            if (node.left != null)
                stack.Push((node.left, true));
            if (node.right != null)
                stack.Push((node.right, false));
            if (node.left == null && node.right == null && isLeft)
                sum += node.val;
        }
        
        return sum;
    }
}