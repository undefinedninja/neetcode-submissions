public class Solution {
    public int MaxArea(int[] height) {
        int right = height.Length - 1;
        int left = 0;
        int maxArea = 0;
        while(left < right)
        {
           int curArea = (right - left) * Math.Min(height[left], height[right]);
            if(curArea > maxArea)
                maxArea = curArea;
            if(height[left] > height[right])
                right--;
            else
                left++;
        }
        return maxArea;
    }
}
