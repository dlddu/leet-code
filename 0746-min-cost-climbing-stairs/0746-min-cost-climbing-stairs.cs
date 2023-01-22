public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        var len = cost.Length;
        
        var downdown = cost[0];
        var down = cost[1];
        
        for (var i = 2; i < len; i++)
        {
            var next = cost[i] + Math.Min(downdown, down);
            downdown = down;
            down = next;
        }
        
        return Math.Min(downdown, down);
    }
}