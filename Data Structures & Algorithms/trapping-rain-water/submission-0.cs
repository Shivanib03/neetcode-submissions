public class Solution {
    public int Trap(int[] height) {
        var maxLeft = new int[height.Length];
        var maxRight = new int[height.Length];
        int totalWater = 0;
        for(int i = 0; i < height.Length; i++)
        {
            if(i == 0)
                maxLeft[i] = height[i];
            else
                maxLeft[i] = Math.Max(height[i], maxLeft[i-1]);
        }
        for(int i = height.Length - 1; i >= 0; i--)
        {
            if(i == height.Length - 1)
                maxRight[i] = height[i];
            else
                maxRight[i] = Math.Max(height[i], maxRight[i+1]);
        }
        for(int i = 0; i < height.Length; i++)
        {
            totalWater += Math.Min(maxLeft[i], maxRight[i]) - height[i];
        }
        return totalWater;
    }
}
