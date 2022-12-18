public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var length = temperatures.Length;
        var stack = new Stack<(int, int)>();
        var answer = new int[length];

        for (var i = 0; i < length - 1; i++)
        {
            var current = temperatures[i];
            var next = temperatures[i+1];
            
            if (current < next)
            {
                answer[i] = 1;
                while(stack.TryPop(out var pair))
                {
                    var (number, j) = pair;
                    if (number < next)
                        answer[j] = i - j + 1;
                    else
                    {
                        stack.Push((number, j));
                        break;
                    }
                }
            }
            else
                stack.Push((current, i));
        }

        return answer;
    }
}