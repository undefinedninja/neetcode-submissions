public class Solution {
    public int LongestConsecutive(int[] nums) {
        int result = 0;
        HashSet<int> h = new HashSet<int>();
        foreach(int i in nums)
        {
            h.Add(i);
        }
        foreach(int i in h)
        {
            int cur = 1;
            int curEle = i;
            while(h.Contains(curEle + 1))
            {
                cur += 1;
                curEle += 1;
            }
            if(cur > result)
            {
                result = cur;
            }
        }            
        return result;
    }
}
