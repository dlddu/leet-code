public class Solution {
    public int MinDeletionSize(string[] strs) {
        var answer = 0;
        
        for (var j = 0; j < strs[0].Length; j++)
        {
            var previousCharacter = strs[0][j];
            for (var i = 1; i < strs.Length; i++)
            {
                var currentCharacter = strs[i][j];
                if (previousCharacter > currentCharacter)
                {
                    answer++;
                    break;
                }
                previousCharacter = currentCharacter;
            }
        }
        
        return answer;
    }
}