public class TimeMap {
    public Dictionary<string, List<(int timeStamp, string val)>> timeMap;
    public TimeMap() {
        timeMap = new Dictionary<string, List<(int timeStamp, string val)>>();
    }
    
    public void Set(string key, string value, int timestamp) {
        if(timeMap.ContainsKey(key))
        {
            timeMap[key].Add((timestamp, value));
        }
        else
        {
            timeMap[key] = new List<(int, string)>(){(timestamp, value)};
        }
    }
    
    public string Get(string key, int timestamp) {
        if(timeMap.ContainsKey(key))
        {
            var res = timeMap[key];
            int l = 0, r = res.Count - 1;
            int answer = -1;
            //Console.WriteLine($"r: {res.Count}");
            while(l <= r)
            {
                int mid = l + (r - l)/2;
                if(res[mid].timeStamp == timestamp)
                {
                    return res[mid].val;
                }
                else if(res[mid].timeStamp > timestamp)
                {
                    r = mid - 1;
                }
                else
                {
                    answer = mid;
                    l = mid + 1;
                }
            }
            //Console.WriteLine($"mid: {mid}");
            if(answer != -1)
                return res[answer].val;
            else
                return "";
        }
        return "";
    }
}
