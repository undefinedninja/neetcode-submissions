public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        int[] need  = new int[26];
        int[] window  = new int[26];
        if(s2.Length <  s1.Length)
            return false;
        for(int i = 0; i < s1.Length; i++)
        {
            need[s1[i] - 'a']++;
        }

        for(int i = 0; i < s1.Length; i++)
        {
            window[s2[i] - 'a']++;
        }

        for(int i = s1.Length; i < s2.Length; i++)
        {
            if(need.SequenceEqual(window))
                return true;
            window[s2[i - s1.Length] - 'a']--;
            window[s2[i] - 'a']++;
        }
        return need.SequenceEqual(window);
    }
}
