public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> d = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++)
        {
            int sn = target - nums[i];
            if(d.ContainsKey(sn))
                return new int[] {d[sn], i};
            else
                d[nums[i]] = i; 
        }
        return new int[] {-1,-1};
    }
}
