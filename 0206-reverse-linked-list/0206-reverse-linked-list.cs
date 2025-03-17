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
       ListNode curr= head;
       ListNode prev=null;
       while(curr is not null)
       {
        ListNode tempNext = curr.next;
        curr.next = prev;
        prev=curr;
        curr=tempNext; 
       }
       return prev;
    }
}

