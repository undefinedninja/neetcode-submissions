public class Solution {
    public bool IsHappy(int n) {
        HashSet<int> list = new HashSet<int>();

        while(!list.Contains(n))
        {
            list.Add(n);
            n = SumOfSquares(n);
            if(n == 1)
                return true;
        }
        return false;
    }
    public int SumOfSquares(int n)
    {
        int res = 0;
        while(n >0)
        {
            int d = n % 10;
            res = res + (d*d);
            n = n/10;
        }
        return res;
    }
}
