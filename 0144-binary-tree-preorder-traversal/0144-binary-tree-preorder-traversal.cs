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
    public IList<int> PreorderTraversal(TreeNode root) {
        if (root == null) return Array.Empty<int>();
        
        var stack = new Stack<TreeNode>();
        stack.Push(root);
        var ans = new List<int>();
        
        while (stack.TryPop(out var node))
        {
            ans.Add(node.val);
            
            if (node.right != null)
                stack.Push(node.right);
            if (node.left != null)
                stack.Push(node.left);
        }
        
        return ans;
    }
}