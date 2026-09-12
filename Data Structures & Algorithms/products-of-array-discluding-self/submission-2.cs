public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var product = new int[nums.Length];
        var totalProduct = 1;
        var zeroExists = false;
        foreach(int num in nums)
        {
            if(num == 0 && zeroExists == false)
            {    
                zeroExists = true;
                continue;
            }
            totalProduct *= num;
        }
        for(int i = 0; i< nums.Length; i++)
        {
            if(nums[i] == 0)
            {
                product[i] = totalProduct;
            }
            else if(zeroExists && nums[i] != 0)
            {
                product[i] = 0;
            }
            else
                product[i] = totalProduct/nums[i];
        }
        return product;
    }
}
