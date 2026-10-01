public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int i = 0, position = 0;
        while(i < nums.Length)
        {
            if(nums[i] != val)
            {
                nums[position] = nums[i];
                position++;
            }
            i++;
        }
        return position;
    }
}