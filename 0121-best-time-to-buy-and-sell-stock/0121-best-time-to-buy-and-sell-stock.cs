public class Solution {
    public int MaxProfit(int[] prices) {
        var dp = new int[prices.Length];
        
        for (var i = 1; i < prices.Length; i++)
            dp[i] = Math.Max(dp[i-1] + prices[i] - prices[i-1], 0);
        
        return dp.Max();
    }
}