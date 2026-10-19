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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        var nNode = head;
        var curr = head;
        int sz = 1;
        while(curr.next != null)
        {
            sz++;
            curr = curr.next;
        }
        if(sz == n)
        {
            head = head.next;
        }
        else
        {
            n = sz - n;
            while(n >= 1)
            {
                curr = nNode;
                nNode = nNode.next;
                n--;
            }
            curr.next = nNode.next;
        }
        return head;
    }
}
