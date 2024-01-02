/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
/*
LCA - 최소 공통 조상은 트리 구조에서 임의의 두 정점이 갖는 가장 가까운 조상 정점을 의미

p,q 두개의 노드가 현재 노드보다 작음 - 왼쪽에서 검색

p,q 두개의 노드가 현재 노드보다 큼 - 오른쪽에서 검색

p,q 두개의 노드가 현재 노드 사이거나 같음  - 현재노드 반환

*/
public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        
         if (root == null) return null;

         if (p.val > root.val && q.val > root.val) {
            // 두 노드가 현재 노드의 값보다 큰 경우, 오른쪽 서브트리에서 검색
            return LowestCommonAncestor(root.right, p, q);
        } else if(p.val < root.val && q.val < root.val) {
            // 두 노드가 현재 노드의 값보다 작은 경우, 왼쪽 서브트리에서 검색
            return LowestCommonAncestor(root.left, p, q);
        } else {
            // 현재 노드가 두 노드의 값 사이에 있거나 노드 중 하나와 같은 경우
            // 현재 노드가 LCA가 됨
            return root;
        }
    }
}