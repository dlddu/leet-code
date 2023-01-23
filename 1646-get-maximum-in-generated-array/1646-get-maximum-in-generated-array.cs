public class Solution {
    public int GetMaximumGenerated(int n) {
        if (n == 0)
            return 0;
        
        var dp = new int[n + 1];
        dp[0] = 0;
        dp[1] = 1;
        
        var max = 1;
        
        for (var i = 2; i <= n; i++)
        {
            if (i % 2 == 0)
                dp[i] = dp[i / 2];
            else
                dp[i] = dp[(i - 1) / 2] + dp[(i - 1) / 2 + 1];
            
            max = Math.Max(max, dp[i]);
        }
        
        return max;
    }
}