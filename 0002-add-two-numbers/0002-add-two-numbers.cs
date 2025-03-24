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
        Stack<int> list1 = new Stack<int>();
        Stack<int> list2 = new Stack<int>();
        Int64 sumOfTwo=0;
        // Get Nums Of list 1 =>
        ListNode curr = l1;
        while(curr != null)
        {
            list1.Push(curr.val);
            curr = curr.next;
        }

        // Get Nums Of list 2 =>
         curr= l2;
        while(curr != null)
        {
            list2.Push(curr.val);
            curr = curr.next;
        }
        sumOfTwo = convertStackToInt(list1) + convertStackToInt(list2);
        char[] charArray = sumOfTwo.ToString().ToCharArray();
       ListNode newList = new ListNode(int.Parse(charArray[charArray.Length -1].ToString()));    
             curr = newList;
             ListNode Next = null;
        for(int i=charArray.Length - 2; i >=0; i--)
        {
            Next = new ListNode(int.Parse(charArray[i].ToString()));
            curr.next = Next;
            curr = Next;
        }

        return newList;
    }

    public Int64 convertStackToInt(Stack<int> nums){
        StringBuilder s= new StringBuilder();
        while(nums.Count >0)
        {
            s.Append(nums.Pop());
        }
        return Convert.ToInt64(s.ToString());
    }
}