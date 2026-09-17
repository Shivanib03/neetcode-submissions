public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var count = new Dictionary<int, int>();
        var frequency = new List<int>[nums.Length + 1];
        var res = new int[k];
        for(int i = 0; i< frequency.Length; i++)
        {
            frequency[i] = new List<int>();
        }
        foreach(int n in nums)
        {
            if(count.ContainsKey(n))
            {
                count[n]++;
            }
            else
                count[n] = 1;
        }
        foreach(var (key, value) in count)
        {
            frequency[value].Add(key);
        }
        int index = 0;
        for (int i = frequency.Length - 1; i > 0 && index < k; i--) {
            foreach (int n in frequency[i]) {
                res[index++] = n;
                if (index == k) {
                    return res;
                }
            }
        }
        return res;
    }
}
