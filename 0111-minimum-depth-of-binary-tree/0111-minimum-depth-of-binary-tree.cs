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
    public int MinDepth(TreeNode root) {
        if (root == null)
            return 0;
        
        var stack = new Stack<(TreeNode node, int distance)>();
        stack.Push((root, 1));
        var minDistance = 100001;
        
        while (stack.TryPop(out var pair))
        {
            var (node, distance) = pair;
            
            if (node.left == null && node.right == null)
                minDistance = Math.Min(distance, minDistance);
            if (node.right != null)
                stack.Push((node.right, distance + 1));
            if (node.left != null)
                stack.Push((node.left, distance + 1));
        }
        
        return minDistance;
    }
}