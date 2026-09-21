public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var index = new Dictionary<char, int>();
        int tempL = 0, maxL = 0; string substring = "";
        int i = 0, j = 0;
        while(j < s.Length)
        {
            if(index.ContainsKey(s[j]))
            {
                maxL = Math.Max(maxL, j - i);
                if(i <= index[s[j]])
                {
                    i = index[s[j]] + 1;
                }
                index[s[j]] = j;
                j++;
            }
            else
            {
                index[s[j]] = j;
                j++;
            }
        }
        maxL = Math.Max(maxL, j - i);
        return maxL;
        // var index = new HashSet<char>();
        // int tempL = 0, maxL = 0;
        // for(int i = 0; i < s.Length; i++)
        // {
        //     if(index.Contains(s[i]))
        //     {
        //         maxL = Math.Max(tempL, maxL);
        //         index.Clear();
        //         tempL = 1;
        //         index.Add(s[i]);
        //     }
        //     else
        //     {
        //         index.Add(s[i]);
        //         tempL++;
        //     }
        // }
        // maxL = Math.Max(tempL, maxL);
        // return maxL;
    }
}
