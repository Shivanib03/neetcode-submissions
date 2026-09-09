public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
            return false;
        var countChar = new Dictionary<char, int>();
        for(int i = 0; i < s.Length; i++)
        {
            countChar[s[i]] = countChar.GetValueOrDefault(s[i]) + 1;
            countChar[t[i]] = countChar.GetValueOrDefault(t[i]) - 1;
        }
        foreach(var (key, value) in countChar)
        {
            if(value != 0)
                return false;
        }
        return true;
    }
}
