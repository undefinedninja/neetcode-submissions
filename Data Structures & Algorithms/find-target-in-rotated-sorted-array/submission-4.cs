public class Solution {
    public int Search(int[] nums, int target) {
        int pi = GetPivotIndex(nums);
        int l = 0;
        int r = nums.Length - 1;
        if(nums[pi] <= target && target <= nums[r])
        {
            l = pi;
        }
        else
            r = pi;
        while(l <= r)
        {
            int mid = l + (r - l)/2;
            if(nums[mid] == target)
            {
                return mid;
            }
            if (nums[mid] < target)
            {
                l = mid + 1;
            }
            else
            {
                r = mid - 1;
            }
            mid = l + (r - l)/2;
        }
        return -1;
    }

    public int GetPivotIndex(int[] nums)
    {
        int l = 0;
        int r = nums.Length - 1;
        while(l < r)
        {
            int mid = l + (r - l)/2;
            if (nums[mid] > nums[r])
            {
                l = mid + 1;
            }
            else
            {
                r = mid;
            }
        }
        return l;
    } 
}
