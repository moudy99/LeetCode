public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
     int SmallBetween =0;
    Dictionary<int,int> dic = new Dictionary<int,int>();

        for(int i=0; i<nums.Length; i++)
        {
            if(dic.ContainsKey(nums[i]))
            {
                SmallBetween = Math.Abs(dic[nums[i]] - i );
                if(SmallBetween <= k) 
                {
                    return true;
                }else{
                   dic[nums[i]] = i;
                };
                    
            }else{
                dic[nums[i]] = i; 
            }
        }
    return false;
    }
}