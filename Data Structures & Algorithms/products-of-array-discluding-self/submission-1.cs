public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int totalProduct = 1;
        int[] result = new int[nums.Length];
        int zeroCount = 0;
        foreach(int n in nums)
        {
            if(n != 0)
                totalProduct *= n;
            else
                zeroCount++;
        }

        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] == 0)
                result[i] = (zeroCount > 1) ? 0 : totalProduct; 
            else if(zeroCount > 0)
                result[i] = 0;
            else
                result[i] = totalProduct / nums[i];
        }
        return result;
    }
}
