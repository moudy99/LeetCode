public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> set = new HashSet<int>(nums);
        int LongestSequens = 0;

        foreach(var num in set)
        {
            if(!set.Contains(num - 1))
            {
                var sum = TotalSequens(num,set);
                if(LongestSequens < sum) LongestSequens = sum;
            }
        }
        return LongestSequens;
    }

    private int TotalSequens(int num, HashSet<int> set)
    {
        bool exsit = false;
        int result = 0;

        while(!exsit)
        {
            if(set.Contains(num))
            {
                result = result + 1;
                num = num + 1;
            }else{
                exsit = true;
            }
        }
        return result;
    }
}