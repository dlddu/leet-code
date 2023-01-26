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
    public IList<int> PostorderTraversal(TreeNode root) {
        if (root == null)
            return Array.Empty<int>();
        
        var stack = new Stack<(TreeNode node, int val)>();
        var ans = new List<int>();
        var node = root;
        
        while (node != null || stack.Any())
        {
            if (node != null)
            {
                stack.Push((node.right, node.val));
                node = node.left;
            }
            else
            {
                var pair = stack.Pop();
                
                node = pair.node;
                if (node != null)
                    stack.Push((null, pair.val));
                else
                    ans.Add(pair.val);
            }
        }
        
        return ans;
    }
}