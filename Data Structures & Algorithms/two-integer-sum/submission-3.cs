public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var index = new Dictionary<int, int>();
        var result = new int[2];
        for(int i = 0; i < nums.Length; i++)
        {
            index[nums[i]] = i;
        }
        for(int i = 0; i < nums.Length; i++)
        {
            var remaining = target - nums[i];
            if(index.ContainsKey(remaining))
            {    
                if(i != index[remaining])
                {   
                    result[0] = i;
                    result[1] = index[remaining];
                    return result;
                }
            }
        }
        return result;
    }
}
