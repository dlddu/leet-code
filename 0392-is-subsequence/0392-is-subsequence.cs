public class Solution {
    public bool IsSubsequence(string s, string t) {
        var si = 0;
        var sLen = s.Count();
        var tLen = t.Count();
        
        if (sLen == 0) return true;
        if (tLen == 0) return false;
        
        for (var ti = 0; ti < tLen; ti++)
        {
            if (t[ti] == s[si])
                si++;
            if (si == sLen)
                return true;
            if (tLen - ti < sLen - si)
                return false;
        }
        
        return false;
    }
}