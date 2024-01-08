/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode ReverseList(ListNode head) {
           if (head == null || head.next == null)
         {
             return head; // 빈 리스트이거나 단일 노드인 경우 그대로 반환
         }

         ListNode prev = null;
         ListNode current = head;

         while (current != null)
         {
             ListNode nextNode = current.next;
             current.next = prev;
             prev = current;
             current = nextNode;

         }

         return prev; // 역순으로 뒤집은 리스트의 새로운 헤드를 반환
    }
}