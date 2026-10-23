public class Solution {
    public int Search(int[] nums, int target) {
        int l = 0, r = nums.Length - 1;
        while(l < r)
        {
            if(nums[l] < nums[r])
                break;
            int mid = l + (r - l) / 2;
            if(nums[mid] < nums[r])
            {
                r = mid;
            }
            else
            {
                l = mid + 1;
            }
        }
        Console.WriteLine($"l : {l}");
        if(target > nums[nums.Length - 1])
        {
            r = l - 1;
            l = 0;
        }
        else
        {
            r = nums.Length - 1;
        }

        while(l < r)
        {
            int mid = l + (r - l)/2;
            if(nums[mid] == target)
                return mid;
            if(nums[mid] < target)
            {
                l = mid + 1;
            }
            else
            {
                r = mid;
            }
        }
        
        if(nums[l] == target)
            return l;
        return -1;
    }
}
