public class Solution {
    public string GcdOfStrings(string str1, string str2) {
        var (shortString, longString) = GetCompare(str1, str2);
        
        while (longString.Length != shortString.Length)
        {
            if (IsDivided(longString, shortString) && IsDivided(str1, shortString) && IsDivided(str2, shortString)) return shortString;
            var temp = longString.Length - shortString.Length;
            (shortString, longString) = GetCompare(shortString, longString.Substring(0, temp));
        }
        
        return IsDivided(longString, shortString) && IsDivided(str1, shortString) && IsDivided(str2, shortString) ? shortString : "";
    }
    
    private bool IsDivided(string longString, string shortString)
    {
        if (longString.Length % shortString.Length != 0) return false;
        
        for (var i = 0; i < longString.Length; i += shortString.Length)
            if (longString.Substring(i, shortString.Length) != shortString) return false;
        
        return true;
    }
    
    private (string shortString, string longString) GetCompare(string str1, string str2)
    {
        if (str1.Length > str2.Length)
            return (str2, str1);
        else
            return (str1, str2);
    }
}