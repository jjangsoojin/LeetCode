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
        /*
         내가 짠 코드
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
        */
        
        // 빠른 포인터가 리스트의 끝에 도달할 때, 느린 포인터는 중간에 위치하게 된다
        
            ListNode slow = head;
            ListNode fast = head;
             
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            return slow;
        
    }
}