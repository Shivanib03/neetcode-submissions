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
    public bool HasCycle(ListNode head) {
        while(head != null)
        {
            if(head.val != -1001)
            {
                head.val = -1001;
                head = head.next;
            }
            else
            {
                return true;
            }
        }
        return false;
    }
}
