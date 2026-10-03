public class Solution {
    public int MajorityElement(int[] nums) {
        int currElement = nums[0];
        int count = 0;
        for(int i = 1; i < nums.Length; i++)
        {
            if(nums[i] == currElement)
            {
                count++;
            }
            else if(count <= 0)
            {
                currElement = nums[i];
            }
            else
            {
                count--;
            }
        }
        return currElement;
    }
}