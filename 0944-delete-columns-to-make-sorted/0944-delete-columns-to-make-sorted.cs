public class Solution {
    public int MinDeletionSize(string[] strs) {
        var answer = 0;
        
        for (var j = 0; j < strs[0].Length; j++)
        for (var i = 1; i < strs.Length; i++)
        {
            if (strs[i-1][j] > strs[i][j])
            {
                answer++;
                break;
            }
        }
        
        return answer;
    }
}