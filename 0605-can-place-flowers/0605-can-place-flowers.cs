public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        if (n == 0) return true;
        
        var ans = 0;
        
        for (var i = 0; i < flowerbed.Length; i++)
        {
            if (flowerbed[i] == 1) continue;
            
            if (!inLeft(flowerbed, i) && !inRight(flowerbed, i))
            {
                flowerbed[i] = 1;
                ans++;
            }
            
            if (ans == n) return true;
        }
        
        return false;
    }
    
    private bool inLeft(int[] flowerbed, int n)
    {
        if (n == 0) return false;
        return flowerbed[n-1] == 1;
    }
    
    private bool inRight(int[] flowerbed, int n)
    {
        if (n == flowerbed.Length-1) return false;
        return flowerbed[n+1] == 1;
    }
}