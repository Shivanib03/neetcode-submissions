public class Solution {
    public int EvalRPN(string[] tokens) {
        int l = 0, r = 0;
        var caluclator = new Stack<int>();
        var operators = new HashSet<string> {"+","-","*","/"};
        for(int i = 0; i < tokens.Length; i++)
        {
            if(operators.Contains(tokens[i]))
            {
                r = caluclator.Pop();
                l = caluclator.Pop();
                int res = 0;
                switch (tokens[i]) {
                    case "+":
                        res = l + r;
                        break;
                    case "-":
                        res = l - r;
                        break;
                    case "*":
                        res = l * r;
                        break;
                    default:
                        res = l / r;
                        break;
                }
                caluclator.Push(res);
            }
            else
            {
                caluclator.Push(int.Parse(tokens[i]));
            }
        }
        return caluclator.Pop();
    }
}
