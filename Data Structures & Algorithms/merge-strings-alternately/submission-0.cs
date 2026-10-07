public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int i = 0, j = 0; string res = "";
        while(i < word1.Length && j < word2.Length)
        {
            if(i == j)
            {
                res = res + "" + word1[i]; i++;
            }
            else
            {
                res = res + "" + word2[j]; j++;
            }
        }
        while(i < word1.Length)
        {
            res = res + "" + word1[i]; i++;
        }
        while(j < word2.Length)
        {
            res = res + "" + word2[j]; j++;
        }
        return res;
    }
}