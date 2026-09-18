public class Solution {

    public string Encode(IList<string> strs) {
        List<int> sizes = new List<int>();
        var encoded = new StringBuilder();
        foreach(string str in strs)
        {
            sizes.Add(str.Length);
        }
        foreach(int n in sizes)
        {
            encoded.Append(n).Append(',');
        }
        encoded.Append('#');
        foreach(string str in strs)
        {
            encoded.Append(str);
        }
        return encoded.ToString();
    }

    public List<string> Decode(string s) {
        if(s.Length == 0)
            return new List<string>();
        var decode = new List<string>();
        var sizes = new List<int>();
        int i = 0, j = 0;
        while(s[i] != '#')
        {
            if(s[i] == ',')
            {
                sizes.Add(int.Parse(s.Substring(j, i - j)));
                j = i + 1;
                i++;
            }
            else
            {
                i++;
            }
        }
        i++;
        Console.WriteLine(string.Join(", ", sizes));
        foreach(int size in sizes)
        {
            decode.Add(s.Substring(i, size));
            i += size;
        }
        return decode;
   }
}
