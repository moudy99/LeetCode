public class Solution {
    //brute force 
    // public int MaxProfit(int[] prices) {
    //     int totalProfit=0;

    //     for(int i=0; i < prices.Length; i++)
    //     {
    //         for(int j=i ; j < prices.Length; j++)
    //         {
    //             if(prices[j] - prices[i] > totalProfit) totalProfit= prices[j] - prices[i];
    //         }
    //     }
    //     return totalProfit;
      //optimize Solution  // Complexity O(n)
    public int MaxProfit(int[] prices) {
        int totalProfit=0;
        int minPrice = int.MaxValue;
        for(int i=0; i < prices.Length; i++)
        {
            if(prices[i] < minPrice) minPrice=prices[i];
            if(prices[i] - minPrice > totalProfit) 
               totalProfit = prices[i] - minPrice;
        }
        return totalProfit;
    }
}