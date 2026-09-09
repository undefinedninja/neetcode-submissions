public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        Dictionary<char, int> d = new Dictionary<char, int>();
        int maxFreq = 0;
        int countMax = 0;
        foreach(char c in tasks)
        {
            if(d.ContainsKey(c))
                d[c]++;
            else
                d.Add(c, 1);

            if(d[c] > maxFreq)
                maxFreq = d[c];
        }

        countMax = d.Where(c => c.Value == maxFreq).Count(); 
       return Math.Max((maxFreq - 1) *(n+1) + countMax, tasks.Length);
    }
}
