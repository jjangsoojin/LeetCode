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

/*
Balanced Binary Search Tree - 균형이진트리
모든 노드의 왼쪽과 오른쪽 하위 트리의 높이가 최대 1만큼 차이가 날 수 있는 이진 트리다.
*/
public class Solution {
    public bool IsBalanced(TreeNode root) {
            int diff = CheckBalanced(root);

            if(diff == -1)
            {
                return false;
            }
            return true;
    }

    
        private int CheckBalanced(TreeNode node)
        {
            if (node == null)
            {
                return 0; // Height of an empty tree is 0
            }

            int leftHeight = CheckBalanced(node.left);

            if (leftHeight == -1)
            {
                return -1; // Left subtree is unbalanced
            }

            int rightHeight = CheckBalanced(node.right);
            if (rightHeight == -1)
            {
                return -1; // Right subtree is unbalanced
            }

            int heightDiff = Math.Abs(leftHeight - rightHeight);        // 절대값 추출
            if (heightDiff > 1)
            {
                return -1; // The tree is unbalanced
            }

            return Math.Max(leftHeight, rightHeight) + 1; // Return the height of the current node's subtree
        }
}
