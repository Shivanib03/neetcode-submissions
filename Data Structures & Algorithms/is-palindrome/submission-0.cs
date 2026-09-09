public class Solution {
    public bool IsPalindrome(string s) {
        if (s.Length == 1)
            return true;
        int i=0,j=s.Length - 1;
        while(i < j)
        {
            if(!char.IsLetterOrDigit(s[i]))
            {
                i++; continue;
            }
            if(!char.IsLetterOrDigit(s[j]))
            {
                j--; continue;
            }
            if(char.ToLowerInvariant(s[i]) != char.ToLowerInvariant(s[j]))
            {
                return false;
            }
            else {i++;j--;}
        }
        return true;
    }
}
