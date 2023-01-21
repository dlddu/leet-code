public class Solution {
    public int MaxProfit(int[] prices) {
        var dp = new int[prices.Length];
        var max = 0;
        
        for (var i = 1; i < prices.Length; i++)
        {
            dp[i] = Math.Max(dp[i-1] + prices[i] - prices[i-1], 0);
            if (dp[i] > max)
                max = dp[i];
        }
        
        return max;
    }
}