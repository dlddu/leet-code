public class Solution {
    public int FindJudge(int n, int[][] trust) {
        if (n == 1)
            return trust.Any() ? -1 : 1;
        
        var trustCount = new int[n + 1];
        var trustAny = new bool[n + 1];
        var passed = new List<int>();
        
        foreach (var t in trust)
        {
            var a = t[0];
            var b = t[1];
            
            trustCount[b]++;
            trustAny[a] = true;
            
            if (trustCount[b] == n-1)
            {
                if (passed.Any()) return -1;
                passed.Add(b);
            }
        }
        var maybe = passed.SingleOrDefault();
        if (maybe == 0 || trustAny[maybe]) return -1;
        
        return maybe;
    }
}