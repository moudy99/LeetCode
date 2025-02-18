public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        Dictionary<int,bool> numDic = new Dictionary<int, bool>();
 bool result = false;
 for(int i=0; i<nums.Length;i++)
 {
     if (numDic.ContainsKey(nums[i]))
         {

         result = true;
         }
         else
         {
         numDic.Add(nums[i], true);
     }

 }
 return result; 
    }
}