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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode result = null;
        ListNode res = null;
        ListNode prev = null;
        int carry = 0;
        while(l1 != null && l2 != null)
        {
            res = new ListNode();
            if(result == null)
            {
                result = res;
                prev = res;
            }
            else
            {
                prev.next = res;
                prev = prev.next;
            }
            var sum = carry + l1.val + l2.val;
            carry = sum / 10;
            res.val = sum % 10;
            l1 = l1.next;
            l2 = l2.next;
        }
        while(l1 != null)
        {
            res = new ListNode();
            prev.next = res;
            prev = prev.next;
            var sum = carry + l1.val;
            carry = sum / 10;
            res.val = sum % 10;
            l1 = l1.next;
            res = res.next;
        }
        while(l2 != null)
        {
            res = new ListNode();
            prev.next = res;
            prev = prev.next;
            var sum = carry + l2.val;
            carry = sum / 10;
            res.val = sum % 10;
            l2 = l2.next;
            res = res.next;
        }
        if(carry != 0)
        {
            res = new ListNode(carry);
            prev.next = res;
        }
        return result;
    }
}
