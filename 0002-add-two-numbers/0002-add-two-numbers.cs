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
// just to start the new list then i will return the next as the first item in the list that added
        ListNode newList = new ListNode(0); 
        ListNode curr = newList;
        int remain = 0;

        while(l1 != null || l2 != null || remain >0)
        {
            int val1 = l1 != null ? l1.val : 0;
            int val2 = l2 != null ? l2.val : 0;

          int sum =val1+val2+remain;
            remain = sum /10 ;
            int newNum = sum % 10;

            curr.next= new ListNode(newNum); 
            curr = curr.next;

           if( l1 != null)  l1 = l1.next;
         if(l2 != null)  l2 = l2.next;
        }
        return newList.next;
    }
}