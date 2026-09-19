public class Solution {
    public int CharacterReplacement(string s, int k) {
        Dictionary<char, int> count = new Dictionary<char, int>();
        int res = 0;
        int dc = 0;
        int maxf = 0;
        for(int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            if(count.ContainsKey(c))
                count[c]++;
            else
                count[c] = 1;
            
            maxf = Math.Max(maxf, count[c]);

            while((i - dc + 1) - maxf > k)
            {
                count[s[dc]]--;
                dc++;
            }
            res = Math.Max(res, i - dc + 1);
        }
        return res;
    }
}
