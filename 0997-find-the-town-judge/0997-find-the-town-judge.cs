public class Solution {
    public int FindJudge(int n, int[][] trust) {
        if (n == 1)
            return trust.Any() ? -1 : 1;
        
        var dict = new Dictionary<int, List<int>>();
        var candidate = Enumerable.Range(0, n).ToList();
        
        foreach (var t in trust)
        {
            if (!dict.ContainsKey(t[1]))
                dict[t[1]] = new List<int>();
            dict[t[1]].Add(t[0]);
            
            candidate.Remove(t[0] - 1);
        }
        
        var mostTrusted = dict.Where(kv => kv.Value.Count() == n - 1);
        
        if (mostTrusted.Count() != 1) return -1;
        var maybe = mostTrusted.Single().Key;
        if (!candidate.Contains(maybe - 1)) return -1;
        
        return maybe;
    }
}