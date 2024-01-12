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
    public ListNode MiddleNode(ListNode head) {
          // 중간노드 반환
          int count = 0;
          ListNode newlist = head;
          while (newlist != null)
          {

              newlist = newlist.next;
              count++;
          }
          count = count / 2 + 1;

          for(int i = 1; i<count; i++){
              head = head.next;
          }

          return head;

    }
}