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
        var ans = new List<int>();
        
        var stack = new Stack<TreeNode>();
        var node = root;
        
        while (node != null || stack.Any())
        {
            if (node != null)
            {
                stack.Push(node);
                node = node.left;
            }
            else
            {
                node = stack.Pop();
                ans.Add(node.val);
                node = node.right;
            }
        }
        
        return ans;
    }
}