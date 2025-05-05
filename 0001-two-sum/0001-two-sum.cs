public class Solution {
    public int[] TwoSum(int[] nums, int target) {
     Dictionary<int,int> dic = new Dictionary<int,int>();

     for(int i=0; i<nums.Length; i++)
     {
        int completness= target - nums[i];
        if(dic.ContainsKey(completness))
        {
            return new int[]{i,dic[completness]};
        }else
        {
            if(!dic.ContainsKey(nums[i]))
            {
                dic[nums[i]] = i;
            }
        }
     }

     return new int[]{};
    }
}