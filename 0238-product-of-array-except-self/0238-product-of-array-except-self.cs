public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int size = nums.Length;
        int[] prefix = new int[size];
        int[] postfix = new int[size];
        int[] returnNums = new int[size];
    int rightPointer=size-1;
        for(int i=0; i<size; i++)
        {
            if(i ==0)
            {
                prefix[i]=nums[i];
                postfix[rightPointer] = nums[rightPointer];
                rightPointer--;
            }else if(i == size -1)
            {
                 postfix[i]=nums[i];
                prefix[i] = nums[i] * prefix[i-1];
                rightPointer--;
            }else
            {
                prefix[i] = prefix[i-1] * nums[i];
                postfix[rightPointer] = postfix[rightPointer+1] * nums[rightPointer];
                rightPointer--;

            }
        }

        for(int i=0; i<size; i++)
        {
            if(i==0)
            {
                returnNums[i] = 1 * postfix[i + 1];
            }else if(i == size -1)
            {
                returnNums[i] = 1 * prefix[i - 1];
            }else
            {
                returnNums[i] = prefix[i - 1] * postfix[i + 1];
            }
        }
        return returnNums;
    }

   
}