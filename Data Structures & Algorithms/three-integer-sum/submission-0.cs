public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        var result = new List<List<int>>();
        Array.Sort(nums);
        for(int i = 0; i < nums.Length - 2; i++)
        {
            if(i>0 && nums[i] == nums[i-1])
                continue;
            int j = i+1; int k = nums.Length - 1;
            while(j<k)
            {
                
                if(nums[j] + nums[k] < -nums[i])
                {
                    j++;
                }
                else if(nums[j] + nums[k] > -nums[i])
                {
                    k--;
                }
                else if(nums[j] + nums[k] == -nums[i])
                {
                    result.Add(new List<int> {nums[i], nums[j], nums[k]});
                    j++; k--;
                    while(j<k && nums[j] == nums[j-1])
                    {
                        j++;
                    }
                }
            }
        }
        return result;
    }
}
