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
        if(head == null || head.next == null)
            return head;
        ListNode first = head;
        ListNode prev = head;
        ListNode curr = prev.next;
        while(curr.next != null)
        {
            var temp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = temp;
        }
        curr.next = prev;
        first.next = null;
        head = curr;
        return head;
    }
}
