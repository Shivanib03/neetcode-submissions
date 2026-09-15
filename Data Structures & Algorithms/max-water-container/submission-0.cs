public class Solution {
    public int MaxArea(int[] heights) {
        int maxWater = 0;
        int i = 0, j = heights.Length - 1;
        while(i < j)
        {
            int ht = Math.Min(heights[i], heights[j]);
            int wt = Math.Abs(i - j);
            maxWater = Math.Max(maxWater, ht * wt);
            if(heights[i] <= heights[j])
                i++;
            else
                j--;
        }
        return maxWater;
    }
}
