public class Solution {
    public int StrStr(string haystack, string needle) {
        for (var i = 0; i < haystack.Length - needle.Length + 1; i++)
            if (haystack[i] == needle[0] && isWord(haystack, needle, i)) return i;
        return -1;
    }
    
    private bool isWord(string haystack, string needle, int i)
    {
        for (var j = 0; j < needle.Length; j++)
            if (haystack[i+j] != needle[j]) return false;
        return true;
    }
}