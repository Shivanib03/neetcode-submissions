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
        var fast = head;
        var slow = head;
        while(fast != null && slow != null)
        {
            slow = slow.next;
            if(fast.next != null)
                fast = fast.next.next;
            else
                return false;
            if(slow == fast)
                return true;
        }
        return false;
        // while(head != null)
        // {
        //     if(head.val != -1001)
        //     {
        //         head.val = -1001;
        //         head = head.next;
        //     }
        //     else
        //     {
        //         return true;
        //     }
        // }
        // return false;
    }
}
