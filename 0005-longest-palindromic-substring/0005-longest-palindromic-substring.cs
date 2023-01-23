public class Solution {
    string s;
    
    public string LongestPalindrome(string s) {
        this.s = s;
        var max = (0, 1);
        
        for (var i = 0; i < s.Length; i++)
        {
            var odd = cal(i, i);
            if (odd.Item2 > max.Item2)
                max = odd;
            
            if (i + 1 < s.Length && s[i] == s[i + 1])
            {
                var even = cal(i, i + 1);
                if (even.Item2 > max.Item2)
                    max = even;
            }
        }
        
        return s.Substring(max.Item1, max.Item2);
    }
    
    private (int, int) cal(int n, int m)
    {
        while (true)
        {
            if (n - 1 < 0 || m + 1 >= s.Length) break;
            
            if (s[n - 1] == s[m + 1])
            {
                n--;
                m++;
            }
            else
                break;
        }
        
        return (n, m - n + 1);
    }
}