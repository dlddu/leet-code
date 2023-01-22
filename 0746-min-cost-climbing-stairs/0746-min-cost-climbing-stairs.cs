public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        var len = cost.Length;
        
        var dp = new int[len];
        dp[0] = cost[0];
        dp[1] = cost[1];
        
        for (var i = 2; i < len; i++)
            dp[i] = cost[i] + Math.Min(dp[i-2], dp[i-1]);
        
        return Math.Min(dp[len-1], dp[len-2]);
    }
}