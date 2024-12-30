public class Solution {
    public int[] RunningSum(int[] nums) {
           int[] arr = new int[nums.Length];
        int sum=0;
        for(int i=0; i< nums.Length; i++){
            sum=0;
            for(int j=0; j<=i ; j++){
                sum += nums[j];
            }
            arr[i] = sum;
        }
        return arr;
    }
}