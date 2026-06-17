public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> d = new  Dictionary<string, List<string>>();

        foreach(string s in strs)
        {
            int[] arr =  new int[26];
            foreach(char c in s)
            {
                arr[c - 'a']++;
            }
            string key = string.Join(",", arr);
            if (!d.TryGetValue(key, out var list))
            {
                list = new List<string>();
                d[key] = list;
            }

            list.Add(s);
        }
        return d.Values.ToList();
    }
}
