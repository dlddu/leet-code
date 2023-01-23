public class Solution {
    public int Fib(int n) {
        if (n == 0)
            return 0;
        
        var front = 0;
        var back = 1;
        for (var i = 2; i <= n; i++)
        {
            var temp = front + back;
            front = back;
            back = temp;
        }
        
        return back;
    }
}