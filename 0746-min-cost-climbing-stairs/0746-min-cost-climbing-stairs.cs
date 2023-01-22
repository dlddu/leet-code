public class Solution {
    private int[] _cost;
    private int[] dp;
    
    public int MinCostClimbingStairs(int[] cost) {
        var len = cost.Length;
        
        _cost = cost.Concat(new int[] { 0 }).ToArray();
        dp = new int[len];
        for (var i = 0; i < len; i++)
            dp[i] = -1;
        
        dp[0] = cost[0];
        dp[1] = cost[1];
        
        return cal(len);
    }
    
    private int cal(int n)
    {
        if (dp[n-2] < 0)
            dp[n-2] = cal(n-2);
        
        if (dp[n-1] < 0)
            dp[n-1] = cal(n-1);
        
        return Math.Min(dp[n-1], dp[n-2]) + _cost[n];
    }
}