public class Solution {
    public void MoveZeroes(int[] nums) {
      if(nums.Length <2) return;
        int[] newArr= new int[nums.Length];
        int counter= 0;
        for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    continue;
                }
                else
                {

                newArr[counter] = nums[i];
                    counter++;
                }
          }
     for(int i=0; i<nums.Length; i++)
     {
        nums[i]=newArr[i];
     }
    }
}

// the brude force - >
/*
*/