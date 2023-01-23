public class Solution {
    public int Tribonacci(int n) {
        if (n == 0)
            return 0;
        if (n == 1)
            return 1;
        if (n == 2)
            return 1;
        
        var first = 0;
        var second = 1;
        var third = 1;
        
        for (var i = 3; i < n; i++)
            (first, second, third) = (second, third, first + second + third);
        
        return first + second + third;
    }
}