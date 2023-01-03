public class Solution {
    public int MinDeletionSize(string[] strs) {
        var current = strs[0];
        var sorted = Enumerable.Range(0, current.Length).ToList();
        
        foreach (var str in strs.Skip(1))
        {
            foreach (var index in sorted.ToArray())
            {
                if (current[index] > str[index])
                    sorted.Remove(index);
            }
            current = str;
        }
        
        return current.Length - sorted.Count;
    }
}