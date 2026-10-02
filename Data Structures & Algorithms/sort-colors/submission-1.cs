public class Solution {
    public void SortColors(int[] nums) {
        if(nums.Length == 1)
        { return;}
        var count = new int[3];
        int index = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            count[nums[i]]++;
        }
        for(int i = 0; i < count.Length; i++)
        {
            while(count[i] > 0)
            {
                nums[index++] = i;
                count[i]--;
            }
        }
    }
}