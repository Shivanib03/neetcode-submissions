public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        var prefix = new StringBuilder(); int i = 1,position = 0;
        foreach(char c in strs[0])
        {
            for(; i < strs.Length; i++)
            {
                if(!string.IsNullOrEmpty(strs[i]) && strs[i].Length > position && c == strs[i][position])
                {
                    continue;
                }
                else
                {
                    break;
                }   
            }
            if(i == strs.Length)
            {
                prefix.Append(c);
                position++; i = 1;
            }
            else
                break;
        }
        return prefix.ToString();
    }
}