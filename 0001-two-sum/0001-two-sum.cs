public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] clone = nums.Clone() as int[];
     int first = 0; 
     int last = nums.Length -1;
        Array.Sort(clone);    

     if(nums.Length == 2)
     {
         return new int[] { 0, 1 };
     }
     while(first < last)
     {
        if((clone[first] + clone[last]) == target)
        {
            int one = Array.IndexOf(nums, clone[first]);
            int two = Array.IndexOf(nums, clone[last]);
            if(one == two)
            {
                two = Array.LastIndexOf(nums,clone[last]);
            }
            return new int[]{one,two};
        }
        else if((clone[first] + clone[last]) > target )
        {
            last--;
        }else if((clone[first] + clone[last]) < target)
        {
            first++;
        }
     }
     return new int[] {};
    }
}