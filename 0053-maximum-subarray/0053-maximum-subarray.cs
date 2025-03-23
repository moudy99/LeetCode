public class Solution {
    public int MaxSubArray(int[] nums) {
        int currSum = 0;
        int maxSum = nums[0];

        for(int i=0; i<nums.Length; i++)
        {
            if(currSum < 0) currSum=0;
            currSum = currSum + nums[i];

            if(maxSum < currSum) maxSum = currSum;
        }
        return maxSum;
    }
}