public class Solution {
    public int FindJudge(int n, int[][] trust) {
        if (n == 1)
            return trust.Any() ? -1 : 1;
        
        var dict = new Dictionary<int, List<int>>();
        var notCand = new bool[n];
        
        foreach (var t in trust)
        {
            if (!dict.ContainsKey(t[1]))
                dict[t[1]] = new List<int>();
            dict[t[1]].Add(t[0]);
            
            notCand[t[0] - 1] = true;
        }
        
        var mostTrusted = dict.Where(kv => kv.Value.Count() == n - 1);
        
        if (mostTrusted.Count() != 1) return -1;
        var maybe = mostTrusted.Single().Key;
        if (notCand[maybe - 1]) return -1;
        
        return maybe;
    }
}