public class Solution {
    public int MaxProfit(int[] prices) {
        var max = 0;
        var beforeProfit = 0;
        
        for (var i = 1; i < prices.Length; i++)
        {
            beforeProfit = Math.Max(beforeProfit + prices[i] - prices[i-1], 0);
            max = Math.Max(beforeProfit, max);
        }
        
        return max;
    }
}