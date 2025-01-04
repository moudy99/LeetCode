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
  public ListNode MiddleNode(ListNode head)
  {
      int counter = 0;
      ListNode current = head;
      
      while (current is not null)
      {
          current = current.next;
          counter++;
      }

      ListNode MiddleNode = new ListNode();
      var middle = Math.Ceiling(counter / 2.0);
        if(counter % 2 ==0) middle++;
      current = head;
      for (int i = 1; i <=counter; i++)
      {
          if(i == Convert.ToInt32(middle))
          {
              MiddleNode = current;
          }

          current = current.next;
      }
      
      return MiddleNode;


  }
}