public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        Dictionary<int,bool> dic = new Dictionary<int,bool>();
        List<int> lis = new List<int>();
        for(int i=0; i<nums1.Length; i++)
        {
            dic[nums1[i]]= false;
        }

        for(int i=0; i<nums2.Length; i++)
        {
            if(dic.ContainsKey(nums2[i]))
            {
                if(!dic[nums2[i]])
                {    
                    dic[nums2[i]] = true;
                    lis.Add(nums2[i]);
                }

            }
        }

       return lis.ToArray();

    }
}