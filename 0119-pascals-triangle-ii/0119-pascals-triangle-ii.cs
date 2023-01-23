public class Solution {
    public IList<int> GetRow(int rowIndex) {
        var list = new List<int>(rowIndex) { 1 };
        
        for (var i = 0; i < rowIndex; i++)
        {
            for (var j = 0; j < i; j++)
                list[i - j] = list[i - j] + list[i - j - 1];
            
            list.Add(1);
        }
        
        return list;
    }
}