public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if(s2.Length < s1.Length)
            return false;

        int left = 0;
        int right = s1.Length - 1;
        int[] s1f = new int[26];
        foreach(char c in s1)
        {
            int n = c - 'a';
            s1f[n]++;
        }
        while (right < s2.Length)
        {
            int[] s2f = new int[26];
            for(int i = left; i<=right; i++)
            {
                int n = s2[i] - 'a';
                s2f[n]++;
            }
            if (s2f.SequenceEqual(s1f))
                return true;

            left++;
            right++;
        }
        return false;
    }
}
