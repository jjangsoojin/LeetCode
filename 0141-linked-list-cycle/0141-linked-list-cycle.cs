/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        
        if (head == null || head.next == null) {
            return false;
        }
        
            if (head.next == null)
            {
                return false;
            }

            ListNode slow = head;
            ListNode fast = head.next;

            while (slow != fast) 
            {
                if (fast == null || fast.next == null)
                {
                    return false;
                }

                slow = slow.next;
                fast = fast.next.next;  //만약 순환 사이클이 있다면, fast 포인터는 slow 포인터를 추월하고 언젠가는 두 포인터가 만남. 만약 fast = fast.next로만 이동한다면 fast와 slow 포인터는 같은 노드에서 만날 수 없음. 또한 next를 많이 쓴다고 해서 속도가 더 빨라지는것도 아님
            }

            return true;
        
    }
}