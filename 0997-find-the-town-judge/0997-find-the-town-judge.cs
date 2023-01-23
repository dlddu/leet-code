public class Solution {
    public int FindJudge(int n, int[][] trust) {
        if (n == 1)
        {
            if (trust.Any())
                return -1;
            return 1;
        }
        if (!trust.Any()) return -1;
        
        var dict = new Dictionary<int, List<int>>();
        
        foreach (var t in trust)
        {
            if (!dict.ContainsKey(t[0]))
                dict[t[0]] = new List<int>();
            dict[t[0]].Add(t[1]);
        }
        
        if (dict.Count() != n - 1) return -1;
        
        IEnumerable<int> inter = dict[trust[0][0]];
        foreach (var (key, value) in dict)
            inter = inter.Intersect(value);
        
        if (inter.Count() == 1)
            return inter.First();
        return -1;
    }
}