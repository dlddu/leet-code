public class Solution {
    private int width;
    private int height;
    private int[][] grid;
    public int IslandPerimeter(int[][] grid) {
        this.grid = grid;
        height = grid.Length;
        width = grid[0].Length;
        var sum = 0;
        
        for (var i = 0; i < height; i++)
        for (var j = 0; j < width; j++)
        {
            if (grid[i][j] == 1)
                sum += cal(i, j);
        }
        
        return sum;
    }
    
    private int cal(int row, int col)
    {
        return 4 - countAdjacent(row, col);
    }
    
    private int countAdjacent(int row, int col)
    {
        var count = 0;
        
        if (row > 0 && grid[row - 1][col] == 1)
            count++;
        if (row < height - 1 && grid[row + 1][col] == 1)
            count++;
        if (col > 0 && grid[row][col - 1] == 1)
            count++;
        if (col < width - 1 && grid[row][col + 1] == 1)
            count++;
        
        return count;
    }
}