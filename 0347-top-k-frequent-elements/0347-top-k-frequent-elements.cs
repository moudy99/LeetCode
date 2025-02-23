public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
    Dictionary<int, int> dic = new Dictionary<int, int>();
   
   for (int i = 0; i < nums.Length; i++)
   {
       if (!dic.ContainsKey(nums[i]))
       {
           dic.Add(nums[i], 1);
       }
   }
        return dic.Select(s=>s.Key).OrderBy(a=>a).Take(k).ToArray();

    }
}