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
        
     int maxDepth = Depth(root);
      
      return maxDepth;
  }

  public int Depth(TreeNode root)
  {
  
       if(root==null)
     return 0;
      
      return Math.Max(Depth(root.left),Depth(root.right)) + 1;

    }
}