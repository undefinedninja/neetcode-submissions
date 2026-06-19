public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        Dictionary<int, int> d = new Dictionary<int,int>();
        for(int i = 0; i < numbers.Length; i++)
        {
            int sn = target - numbers[i];
            if(d.ContainsKey(sn))
                return new int[] {d[sn] + 1, i + 1 };
            else 
                d[numbers[i]] = i;
        }
        return new int[] {-1, -1};
    }
}
