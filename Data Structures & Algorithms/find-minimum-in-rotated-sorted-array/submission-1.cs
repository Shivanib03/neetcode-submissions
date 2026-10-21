public class Solution {
    public int FindMin(int[] nums) {
        int l = 0, r = nums.Length - 1;
        while(l < r)
        {
            int mid = l + (r - l)/2;
            if(mid == 0)
            {
                if(nums[mid] < nums[mid+1])
                {
                    return nums[mid];
                }
            }
            else if(mid == nums.Length - 1)
            {
                if(nums[mid] < nums[mid - 1] && nums[mid] < nums[0])
                {
                    return nums[mid];
                }
            }
            else if(nums[mid-1] > nums[mid] && nums[mid] < nums[mid+1])
            {
                return nums[mid];
            }
            if(nums[mid] > nums[r])
            {
                l = mid + 1;
            }
            else 
                r = mid;
        }
        return nums[l];
    }
}
