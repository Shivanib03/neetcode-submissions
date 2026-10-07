public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int pos = 1, j = 1, curr = nums[0];
        while(j < nums.Length)
        {
            if(nums[j] == curr)
            {
                j++;
            }
            else
            {
                curr = nums[j];
                nums[pos] = nums[j];
                j++; pos++;
            }
        }
        return pos;
    }
}