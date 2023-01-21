public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        var arr = new List<IList<int>>(numRows);
        arr.Add(new List<int> { 1 });
        
        for (var i = 2; i <= numRows; i++)
        {
            var lastRow = arr[i-2];
            var newRow = new List<int> { 1 };
            for (var j = 0; j < i - 2; j++)
                newRow.Add(lastRow[j] + lastRow[j+1]);
            newRow.Add(1);
            arr.Add(newRow);
        }
        
        return arr;
    }
}