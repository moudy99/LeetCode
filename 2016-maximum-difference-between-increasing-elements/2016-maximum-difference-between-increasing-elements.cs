public class Solution {
    public int MaximumDifference(int[] nums) {
        int MaxDiff = int.MinValue;
            // for(int i=0; i<nums.Length; i++)
            // {
            //     for(int j= i + 1; j<nums.Length; j++)
            //     {   
            //         if(j>i && nums[j] > nums[i]) {
            //             if(nums[j] - nums[i] > MaxDiff )
            //             MaxDiff = nums[j] - nums[i];
            //         }
            //     }
            // }

            int MinV =0;
            for(int i=0; i<nums.Length; i++)
            {
                if( nums[MinV] > nums[i] ) MinV = i;

                if(nums[MinV] < nums[i] && MinV < i )
                {
                    if(nums[i] - nums[MinV] > MaxDiff )
                    MaxDiff = nums[i] - nums[MinV];
                }

            }
            return MaxDiff > 0 ? MaxDiff : -1;
    }
}