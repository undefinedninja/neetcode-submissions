public class Solution {
    public int Search(int[] nums, int target) {
        int left = 0;
        int right = nums.Length;
        
        while(left < right)
        {
            int mid = (left + right) / 2;
            if(nums[mid] == target)
            {
                return mid;
            }
            else if(target > nums[mid])
            {
                left = mid +1;
            }
            else
            {
                right = mid;
            }
        }
        return -1;
    }
}
