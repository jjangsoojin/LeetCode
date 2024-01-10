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
    private int diameter;
    
    public int DiameterOfBinaryTree(TreeNode root) {
            
            diameter = 0;
            Depth(root);
            return diameter;
        }

        public int Depth(TreeNode node)
        {
           if (node == null)
    return 0;

   int left = Depth(node.left);
   int right = Depth(node.right);
   diameter = Math.Max(diameter, left + right);

   return Math.Max(left, right) + 1;
        }
        
}
