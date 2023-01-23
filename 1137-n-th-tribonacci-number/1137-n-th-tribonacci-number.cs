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
        {
            var temp = first + second + third;
            first = second;
            second = third;
            third = temp;
        }
        
        return first + second + third;
    }
}