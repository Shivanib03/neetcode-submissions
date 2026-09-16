public class Solution {
    public bool IsValid(string s) {
        var stk = new Stack<int>();
        for(int i = 0; i < s.Length; i++)
        {
            if(stk.Count > 0 &&
                (stk.Peek() == '(' && s[i] == ')' ||
                stk.Peek() == '{' && s[i] == '}' ||
                stk.Peek() == '[' && s[i] == ']'))
                stk.Pop();
            else
                stk.Push(s[i]);
        }
        return stk.Count == 0;
    }
}
