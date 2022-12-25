public class Solution {
    public int[] AnswerQueries(int[] nums, int[] queries) {
        
        var numList = nums.OrderBy(n => n).ToList();
        for (var i = 1; i < numList.Count; i++)
            numList[i] += numList[i-1];
        
        return queries.Select(query => Math.Abs(numList.BinarySearch(query) + 1)).ToArray();
    }
}