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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
          if(list1 == null) return list2;
          if (list2 == null) return list1;
        ListNode newList;
        // first i will select the head of the new array ---->
        if(list1.val > list2.val){
            newList = list2;
            list2 = list2.next;
        }else if(list1.val < list2.val){
            newList = list1;
            list1 = list1.next;
        }else{
            newList = list1;
            list1 = list1.next;
        }
        ListNode curr = newList;

        while(list1 != null || list2 != null)
        {
            // first i check if any of the lists is empty or not 
            if(list1 == null){
                curr.next = list2;
                curr = curr.next;
                list2 = list2.next;
            }else if(list2==null){
                curr.next = list1;
                list1 = list1.next;
                curr = curr.next;
            }

            // here i will add logic if both lists are full with data -> 
            if(list1 != null && list2 != null){
                if(list1.val > list2.val){
                    curr.next = list2;
                    curr = curr.next;
                    list2 =list2.next;
                }else if(list1.val < list2.val){
                    curr.next = list1;
                    curr = curr.next;
                    list1=list1.next;
                }else{ // if both equle so i will chose any one مش فارفة
                    curr.next = list1;
                    curr = curr.next;
                    list1=list1.next;
                }
            }
        }
        return newList;

    }
}
