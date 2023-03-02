public class Solution {
    public int Compress(char[] chars) {
        var selected = '.';
        var consecutive = 0;
        var answer = 0;
        
        foreach (var ch in chars)
        {
            if (answer == 0 && consecutive == 0)
            {
                selected = ch;
                consecutive = 1;
            }
            else if (ch == selected)
            {
                consecutive++;
            }
            else
            {
                answer = writeCompress(consecutive, chars, selected, answer);
                
                selected = ch;
                consecutive = 1;
            }
        }
        
        answer = writeCompress(consecutive, chars, selected, answer);
        
        return answer;
    }
    
    private int writeCompress(int consecutive, char[] chars, char selected, int answer)
    {
        if (consecutive == 1)
        {
            chars[answer] = selected;
            return answer + 1;
        }
        else
        {
            chars[answer] = selected;
            var numString = consecutive.ToString();
            for (var i = 0; i < numString.Length; i++)
                chars[answer + i + 1] = numString[i];
            
            return answer + consecutive.ToString().Length + 1;
        }
    }
}