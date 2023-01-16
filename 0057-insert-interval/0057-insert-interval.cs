public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        var step = 0;
        var head = newInterval[0];
        var tail = newInterval[1];
        var ret = new List<int[]>(intervals.Length);
        
        for (var i = 0; i < intervals.Length; i++)
        {
            var current = intervals[i];
            var start = current[0];
            var end = current[1];
            
            if (step == 0)
            {
                if (head <= start)
                    step++;
                else if (head <= end)
                {
                    head = start;
                    step++;
                }
                else
                {
                    ret.Add(current);
                }
            }
            
            if (step == 1)
            {
                if (tail < start)
                {
                    ret.Add(new[] { head, tail });
                    step++;
                }
                else if (tail <= end)
                {
                    current[0] = head;
                    current[1] = end;
                    step++;
                }
            }
            
            if (step == 2)
                ret.Add(current);
        }
        
        if (step == 0)
            ret.Add(newInterval);
        if (step == 1)
            ret.Add(new[] { head, tail });
    
        return ret.ToArray();
    }
}