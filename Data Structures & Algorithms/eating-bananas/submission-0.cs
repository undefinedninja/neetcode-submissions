public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int left  = 1;
        int right = 0;
        for(int i  = 0; i < piles.Length ; i++)
        {
            if(right < piles[i])
                right = piles[i];
        }

        while(left <= right)
        {
            int mid = left + (right - left)/2;
            
            int sum = 0;
            for(int i = 0 ; i < piles.Length ; i++ )
            {
                sum += (piles[i] + mid - 1) / mid;     
            }
            if(sum > h)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return left;
    }
}
