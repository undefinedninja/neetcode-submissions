public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int left = 0;
        int right = 0;
        HashSet<char> list = new HashSet<char>();
        int maxLength = 0;

        while(right < s.Length)
        {
            if(list.Contains(s[right]))
            {
                while(list.Contains(s[right]))
                {
                    list.Remove(s[left]);
                    left++;
                }
            }
            list.Add(s[right]);
            right++;
            if(maxLength < (right - left))
                maxLength = right - left;
        }
        return maxLength;
    }
}
