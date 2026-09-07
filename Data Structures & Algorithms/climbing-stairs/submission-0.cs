public class Solution {
    public int ClimbStairs(int n) {     
        int prev1 = 1;
        int prev2 = 2;
        if(n < 3)
            return n;
        for (int i = 3; i <= n; i++)
        {
            int current = prev1 + prev2;
            prev1 = prev2;
            prev2 = current;
        }
        return prev2;
    }
}
