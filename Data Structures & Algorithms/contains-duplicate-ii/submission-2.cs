public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        if(nums.Length == 1)
            return false;
        var set = new HashSet<int>();
        int i = 0;
        while(i <= k)
        {
            if(set.Contains(nums[i]))
                return true;
            else
            {    
                set.Add(nums[i]); 
                i++;
            }
        }
        i = 0;
        for(int j = k + 1; j < nums.Length; j++)
        {
            set.Remove(nums[i]);
            i++;
            if(set.Contains(nums[j]))
            {
                return true;
            }
            else
            {
                set.Add(nums[j]);
            }
        }
        return false;
    }
}