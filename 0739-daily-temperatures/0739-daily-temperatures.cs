public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var length = temperatures.Length;
        var stack = new Stack<(int num, List<int> js)>();
        var answer = new int[length];

        for (var i = 0; i < length - 1; i++)
        {
            var current = temperatures[i];
            var next = temperatures[i+1];
            
            if (current < next)
            {
                answer[i] = 1;
                while(stack.Any() && stack.Peek().num < next)
                {
                    foreach (var j in stack.Pop().js)
                        answer[j] = i - j + 1;
                }
            }
            else
            {
                if (stack.Any() && stack.Peek().num == current)
                    stack.Peek().js.Add(i);
                else
                    stack.Push((current, new List<int> { i }));
            }
        }

        return answer;
    }
}