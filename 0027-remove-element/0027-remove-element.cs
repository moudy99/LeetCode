public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int[] nums2=new int[nums.Length];
        int counter=0;
        int index =0;
        for(int i=0; i<nums.Length; i++)
        {
            if(nums[i] == val)
            {
                counter++;
                continue;
            }
            nums2[index] = nums[i];
            index++;
        }
        for(int i=0; i<nums2.Length; i++)
        {
            nums[i] = nums2[i];
        }
        return nums.Length - counter;
    }
}