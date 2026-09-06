public class TimeMap {
    Dictionary<string, List<(string value, int timestamp)>> d = null;
    public TimeMap() {
        this.d = new Dictionary<string,List<(string value, int timestamp)>>();
    }
        
    public void Set(string key, string value, int timestamp) {
        if(this.d.ContainsKey(key))
            this.d[key].Add((value, timestamp));
        else
            this.d[key] = new List<(string value, int timestamp)>() {(value, timestamp)};
    }
    
    public string Get(string key, int timestamp) {
        if(this.d.ContainsKey(key))
        {
            List<(string value, int timestamp)> c = this.d[key];
            string result = String.Empty;
            int left = 0;
            int right = c.Count - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if(c[mid].timestamp <= timestamp)
                {
                    result = c[mid].value;

                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return result;
        }
        else
            return "";
    }
}
