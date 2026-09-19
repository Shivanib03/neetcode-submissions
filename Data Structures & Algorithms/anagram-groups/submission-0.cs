public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var res = new List<List<string>>();
        var groups = new Dictionary<string, List<string>>();
        for(int i = 0; i < strs.Length; i++)
        {
            var freq = new int[26];
            foreach(char c in strs[i])
            {
                freq[c - 'a']++;
            }
            string key = string.Join(",", freq);
            if(groups.ContainsKey(key))
            {
                groups[key].Add(strs[i]);
            }
            else
            {
                groups[key] = new List<string>();
                groups[key].Add(strs[i]);
            }
        }
        foreach(var (key, anagrams) in groups)
        {
            res.Add(anagrams);
        }
        return res;
    }
}
