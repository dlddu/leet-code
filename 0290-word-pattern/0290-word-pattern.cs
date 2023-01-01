public class Solution {
    public bool WordPattern(string pattern, string s) {
        var ss = s.Split();
        if (pattern.Length != ss.Count()) return false;
        var dictionary = new Dictionary<char, string>();
        var values = new HashSet<string>();
        
        foreach (var (ch, word) in pattern.ToCharArray().Zip(ss))
            if (dictionary.ContainsKey(ch))
            {
                if (dictionary[ch] != word) return false;
            }
            else
            {
                if (values.Contains(word)) return false;
                dictionary[ch] = word;
                values.Add(word);
            }
        
        return true;
    }
}