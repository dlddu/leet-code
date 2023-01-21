public class Solution {
    private int[] dp;
    public int[] CountBits(int n) {
        if (n == 0) return new int[] { 0 };
        
        dp = new int[n + 1];
        dp[0] = 0;
        dp[1] = 1;
        
        return Enumerable.Range(0, n + 1).Select(cal).ToArray();
    }
    
    private int cal(int n)
    {
        if (n == 0 || dp[n] > 0)
            return dp[n];
        dp[n] = dp[n - (n & -n)] + 1;
        return dp[n];
    }
}