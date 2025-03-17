public class Solution {
     public void MoveZeroes(int[] nums)
    {

        int numZeroIndx=0;
        for(int i=0; i<nums.Length; i++)
        {
            if(nums[i] !=0)
            {
                nums[numZeroIndx] =nums[i];
                if(i!= numZeroIndx)
                {
                    nums[i]=0;
                }
                numZeroIndx++;
            }

        }

    }
    
}

