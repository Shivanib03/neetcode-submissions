public class Solution {
    public int Search(int[] nums, int target) {
        if(nums.Length == 1 && nums[0] == target)
            return 0;
        int l = 0, r = nums.Length - 1;
        while(l < r)
        {
            int mid = (l + r) / 2;
            if(nums[mid] == target)
                return mid;
            else if(r == l + 1)
            {
                if(nums[r] == target)
                    return r;
                else
                    return -1;
            }
            else if(nums[mid] > target)
                r = mid;
            else if(nums[mid] < target)
                l = mid;
        }
        return -1;
    }
}
