public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int maxWealth =0;
        for(int i=0; i< accounts.Length; i++)
        {
            int sum=0;
            for(int ii=0 ; ii < accounts[i].Length; ii++)
            {
                sum += accounts[i][ii];
            }
            if(sum > maxWealth) maxWealth = sum;
        }
        return maxWealth;
    }
}