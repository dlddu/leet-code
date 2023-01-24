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
    public IList<int> InorderTraversal(TreeNode root) {
        return traverse(root);
    }
    
    private IList<int> traverse(TreeNode node)
    {
        if (node == null) return new List<int>();
        return traverse(node.left).Concat(visit(node)).Concat(traverse(node.right)).ToList();
    }
    
    private IList<int> visit(TreeNode node)
    {
        return new List<int> { node.val };
    }
}